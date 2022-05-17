using System.IO;
using System.Text;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

public static class ApiDocumentationExtensions
{
    public static string ToCSharpDocumentationSummary(this ApiDescription subject)
    {
        if (string.IsNullOrEmpty(subject.Text) && string.IsNullOrEmpty(subject.HelpTopic))
        {
            return string.Empty;
        }
        
        return ToCSharpDocumentationElement(subject, "<summary>", "</summary>");
    }
    
    
    public static string ToCSharpDocumentationSummary(this string subject)
    {
        if (string.IsNullOrEmpty(subject))
        {
            return string.Empty;
        }
        
        return ToCSharpDocumentationElement(new ApiDescription { Text = subject }, "<summary>", "</summary>");
    }

    public static string ToCSharpDocumentationParameter(this ApiDescription subject, string parameterName)
    {
        if (string.IsNullOrEmpty(subject.Text) && string.IsNullOrEmpty(subject.HelpTopic))
        {
            return $"/// <param name=\"{parameterName}\"></param>";
        }

        return ToCSharpDocumentationElement(subject, $"<param name=\"{parameterName}\">", "</param>");
    }
    
    private static string ToCSharpDocumentationElement(this ApiDescription subject, string startElement, string endElement)
    {
        var builder = new StringBuilder();
        builder.AppendLine($"/// {startElement}");
        
        var reader = new StringReader(subject.Text);
        var line = reader.ReadLine();
        while (line != null)
        {
            if (line.StartsWith("@see [") && line.EndsWith("]"))
            {
                // Support for: @see [space.jetbrains.api.runtime.helpers.SpaceScopes]
                line = line
                    .Replace("@see [", "")
                    .Replace("]", "")
                    .Replace("space.jetbrains.api.runtime.helpers.", "");
                
                builder.AppendLine($"/// <see cref=\"{line}\"/>");
            }
            else
            {
                // Regular line
                builder.AppendLine("/// " + line
                    .Replace("<", "&lt;")
                    .Replace(">", "&gt;"));
            }

            line = reader.ReadLine();
        }

        if (!string.IsNullOrEmpty(subject.HelpTopic))
        {
            builder.AppendLine($"/// <a href=\"https://www.jetbrains.com/help/space/{subject.HelpTopic}\">Read more...</a>");
        }
            
        builder.AppendLine($"/// {endElement}");
        return builder.ToString();
    }
}