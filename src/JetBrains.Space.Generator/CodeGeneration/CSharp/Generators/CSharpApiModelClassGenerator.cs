using System.Text;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Generators;

public class CSharpApiModelClassGenerator
{
    private readonly CodeGenerationContext _context;

    public CSharpApiModelClassGenerator(CodeGenerationContext context)
    {
        _context = context;
    }

    public string GenerateClassDefinition(ApiClass apiClass)
    {
        var indent = new Indent();
        var builder = new StringBuilder();
            
        builder.AppendLine($"{indent}// " + apiClass.ToCSharpClassName());

        return builder.ToString();
    }
}