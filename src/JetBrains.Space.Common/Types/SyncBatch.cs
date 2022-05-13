using System.Collections.Generic;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Types;

/// <summary>
/// A class that represents a batch of items since a specific moment.
/// </summary>
/// <typeparam name="T">The type of the items in the <see cref="SyncBatch{T}"/>.</typeparam>
[PublicAPI]
public class SyncBatch<T> 
    : IPropagatePropertyAccessPath
{
    /// <summary>
    /// Get the collection of items in the batch.
    /// </summary>
    [JsonPropertyName("data")]
    public List<T>? Data { get; set; }

    /// <summary>
    /// Represents the etag.
    /// </summary>
    [JsonPropertyName("sinceEtag")]
    public string? SinceEtag { get; set; }

    /// <inheritdoc />
    public void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{parentChainPath}->With{nameof(Data)}()", validateHasBeenSet, Data);
        PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{parentChainPath}->With{nameof(SinceEtag)}()", validateHasBeenSet, SinceEtag);
    }

    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();
}