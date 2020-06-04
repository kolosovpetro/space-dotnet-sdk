﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using SpaceDotNet.Client;
using SpaceDotNet.Client.TDMemberProfileDtoExtensions;
using SpaceDotNet.Common;

namespace SpaceDotNet.Samples.CommandLine
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static async Task Main(string[] args)
        {
            // Create a connection using a service account.
            // NOTE: Service accounts do not have access to all operations in Space!
            var connection = new ClientCredentialsConnection(
                Environment.GetEnvironmentVariable("JB_SPACE_API_URL")!,
                Environment.GetEnvironmentVariable("JB_SPACE_CLIENT_ID")!,
                Environment.GetEnvironmentVariable("JB_SPACE_CLIENT_SECRET")!,
                new HttpClient());
            
            // Get all profiles with their names
            var teamDirectoryClient = new TeamDirectoryClient(connection);
            await foreach (var profile in teamDirectoryClient.Profiles.GetAllProfilesAsyncEnumerable("", false, false, partial: _ => _
                .WithId()
                .WithName()))
            {
                Console.WriteLine($"{profile.Name.FirstName} {profile.Name.LastName}");
            }
        }
    }
}