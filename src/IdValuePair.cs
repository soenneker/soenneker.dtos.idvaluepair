using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Soenneker.Dtos.IdValuePair;

/// <summary>
/// A minimal Record type with an Id (string), Value (string)
/// </summary>
public record IdValuePair
{
    [Required]
    [JsonPropertyName("id")]
    public string Id { get; init; } = null!;

    [Required]
    [JsonPropertyName("value")]
    public string Value { get; init; } = null!;
}
