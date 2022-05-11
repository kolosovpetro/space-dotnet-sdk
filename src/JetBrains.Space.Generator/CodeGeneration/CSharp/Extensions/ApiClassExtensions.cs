using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

public static class ApiClassExtensions
{
    public static string ToCSharpClassName(this ApiClass subject)
        => CSharpIdentifier.ForClassOrNamespace(subject.Name);
}