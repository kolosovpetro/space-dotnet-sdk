﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Generator.CodeGeneration.CSharp;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Generators;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator;

public static class Program
{
    private const string OutputPath = "../../../../JetBrains.Space.Client/Generated/";
    private const string SdkInfoOutputPath = "../../../../JetBrains.Space.Common/Generated/";

    public static async Task<int> Main(string[] args)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Constants.SpaceLogoAscii);
        Console.WriteLine();
        Console.WriteLine("JetBrains Space");
        Console.ResetColor();
        Console.WriteLine();

        // Parse arguments
        var namedArguments = args.ToDictionary(
            it => it.Split('=', 2, StringSplitOptions.RemoveEmptyEntries)[0].TrimStart('-'),
            it =>
            {
                var split = it.Split('=', 2, StringSplitOptions.RemoveEmptyEntries);
                return split.Length > 1 ? split[1] : null;
            }, StringComparer.OrdinalIgnoreCase);
            
        // Determine command to run
        if (namedArguments.ContainsKey("model"))
        {
            return await RunGenerateFromModel(namedArguments);
        }

        if (namedArguments.ContainsKey("organizationUrl"))
        {
            return await RunGenerateFromOrganizationUrl(namedArguments);
        }

        if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("JB_SPACE_API_URL")))
        {
            namedArguments["organizationUrl"] = Environment.GetEnvironmentVariable("JB_SPACE_API_URL");
            namedArguments["clientId"] = Environment.GetEnvironmentVariable("JB_SPACE_CLIENT_ID");
            namedArguments["clientSecret"] = Environment.GetEnvironmentVariable("JB_SPACE_CLIENT_SECRET");
            return await RunGenerateFromOrganizationUrl(namedArguments);
        }

        return await RunHelpAsync();
    }

    private static Task<int> RunHelpAsync()
    {
        Console.WriteLine("Usage: ");
        Console.WriteLine();
        Console.WriteLine("  Generate code from a remote API model:");
        Console.WriteLine("    --organizationUrl=https://{organization}.jetbrains.space/ --clientId={client-id} --clientSecret={client=secret}");
        Console.WriteLine();
        Console.WriteLine("  Generate code from a remote API model (set environment variables):");
        Console.WriteLine("    JB_SPACE_API_URL=https://{organization}.jetbrains.space/");
        Console.WriteLine("    JB_SPACE_CLIENT_ID={client-id} --clientSecret={client=secret}");
        Console.WriteLine("    JB_SPACE_CLIENT_SECRET={client=secret}");
        Console.WriteLine();
        Console.WriteLine("  Generate code from a HA_model.json file:");
        Console.WriteLine("    --model={path-to-HA_model.json} --version={version}");
            
        return Task.FromResult(-1);
    }

    private static async Task<int> RunGenerateFromOrganizationUrl(Dictionary<string, string?> namedArguments)
    {
        if (!namedArguments.TryGetValue("organizationUrl", out var organizationUrl) || string.IsNullOrEmpty(organizationUrl) ||
            !namedArguments.TryGetValue("clientId", out var clientId) || string.IsNullOrEmpty(clientId) ||
            !namedArguments.TryGetValue("clientSecret", out var clientSecret) || string.IsNullOrEmpty(clientSecret))
        {
            return await RunHelpAsync();
        }
            
        Console.WriteLine("Generating code from remote API model...");

        using var httpClient = SharedHttpClient.Instance;
        return await ExecuteCodeGenerator(
            async () =>
            {
                // Load model from API
                var connection = new ClientCredentialsConnection(
                    new Uri(organizationUrl), 
                    clientId,
                    clientSecret,
                    httpClient);
            
                var apiModel = await connection.RequestResourceAsync<ApiModel>(
                    "GET", "api/http/http-api-model?$fields=dto,enums,urlParams,resources(*,nestedResources!),menuIds");
                
                var jsonSerializerOptions = new JsonSerializerOptions()
                    .AddSpaceJsonTypeConverters();
                
                apiModel.Classes = JsonSerializer.Deserialize<List<ApiClass>>(@"[
{
""className"" : ""HA_Class.Interface"",
""visibilityModifier"" : ""DEFAULT"",
""name"" : ""SpacePermission"",
""doc"" : ""Permissions for Space API. Could be used for oauth permission scopes generation.\n@see [space.jetbrains.api.runtime.helpers.SpaceScopes]"",
""implements"" : [ ],
""innerSubclasses"" : [
{
""className"" : ""HA_Class.Object"",
""visibilityModifier"" : ""DEFAULT"",
""name"" : ""AddCustomEmoji"",
""doc"" : """",
""implements"" : [
""SpacePermission""
],
""innerSubclasses"" : [ ],
""properties"" : [
{
""visibilityModifier"" : ""DEFAULT"",
""name"" : ""code"",
""type"" : {
""className"" : ""HA_Type.Primitive"",
""primitive"" : ""String"",
""nullable"" : false,
""tags"" : [ ]
},
""value"" : {
""className"" : ""HA_DefaultValue.Const.Primitive"",
""expression"" : ""\""Emojis.AddCustomEmoji\""""
},
""deprecation"" : null,
""override"" : true
}
],
""deprecation"" : null,
""extends"" : null
},
{
""className"" : ""HA_Class.Object"",
""visibilityModifier"" : ""DEFAULT"",
""name"" : ""AddMembers"",
""doc"" : """",
""implements"" : [
""SpacePermission""
],
""innerSubclasses"" : [ ],
""properties"" : [
{
""visibilityModifier"" : ""DEFAULT"",
""name"" : ""code"",
""type"" : {
""className"" : ""HA_Type.Primitive"",
""primitive"" : ""String"",
""nullable"" : false,
""tags"" : [ ]
},
""value"" : {
""className"" : ""HA_DefaultValue.Const.Primitive"",
""expression"" : ""\""Profile.Create\""""
},
""deprecation"" : null,
""override"" : true
}
],
""deprecation"" : null,
""extends"" : null
}
  ]}]", jsonSerializerOptions);
                    
                return apiModel;
            },
            async () =>
            {
                // Deployment info
                var deploymentInfoClient = new DeploymentInfoClient(
                    organizationUrl, 
                    httpClient);

                var deploymentInfo = await deploymentInfoClient.GetDeploymentInfoAsync();

                Console.WriteLine("Server information:");
                Console.WriteLine(deploymentInfo);

                return deploymentInfo;
            });
    }
        
    private static async Task<int> RunGenerateFromModel(Dictionary<string, string?> namedArguments)
    {
        if (!namedArguments.TryGetValue("model", out var model) ||
            string.IsNullOrEmpty(model) ||
            !namedArguments.TryGetValue("version", out var version) ||
            string.IsNullOrEmpty(version))
        {
            return await RunHelpAsync();
        }
            
        Console.WriteLine($"Generating code from HA_model.json file at '{model}'...");

        return await ExecuteCodeGenerator(
            async () =>
            {
                // Load model from disk
                var jsonSerializerOptions = new JsonSerializerOptions()
                    .AddSpaceJsonTypeConverters();

                var apiModel = JsonSerializer.Deserialize<ApiModel>(
                    await File.ReadAllTextAsync(model), jsonSerializerOptions);
                    
                return apiModel;
            },
            () => Task.FromResult(
                new DeploymentInfo { Version = version })!);
    }

    private static async Task<int> ExecuteCodeGenerator(Func<Task<ApiModel?>> retrieveModel, Func<Task<DeploymentInfo?>> retrieveDeploymentInfo)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        // Get data
        var apiModel = await retrieveModel();
        if (apiModel == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: HTTP API model information is not available.");
            return -1;
        }
            
        var deploymentInfo = await retrieveDeploymentInfo();
        if (deploymentInfo == null || string.IsNullOrEmpty(deploymentInfo.Version))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: Deployment and version information is not available.");
            return -1;
        }
            
        // Remove old code
        var generatedCodePath = Path.GetFullPath(OutputPath);
        if (Directory.Exists(generatedCodePath))
        {
            Directory.Delete(generatedCodePath, recursive: true);
        }

        // Build code
        var codeGenerationContext = CodeGenerationContext.CreateFrom(apiModel, deploymentInfo);
        var csharpApiModelGenerator = new CSharpApiModelGenerator(codeGenerationContext);
        csharpApiModelGenerator.GenerateFiles(
            new CSharpDocumentWriter(
                new DirectoryInfo(Path.GetFullPath(OutputPath))),
            new CSharpDocumentWriter(
                new DirectoryInfo(Path.GetFullPath(SdkInfoOutputPath))));
            
        // Report
        stopwatch.Stop();
        Console.WriteLine($"Code generation completed in: {stopwatch.Elapsed}");
        Console.WriteLine($"  Number of DTO: {codeGenerationContext.GetDtos().Count()}");
        Console.WriteLine($"  Number of Enums: {codeGenerationContext.GetEnums().Count()}");
        Console.WriteLine($"  Number of Classes: {codeGenerationContext.GetClasses().Count()}");
        Console.WriteLine($"  Number of Resources (top level): {codeGenerationContext.GetResources().Count()}");
            
        // Write version marker
        await File.WriteAllTextAsync("../../../../../version-info.txt", deploymentInfo.Version.Trim());
            
        return 0;
    }
}