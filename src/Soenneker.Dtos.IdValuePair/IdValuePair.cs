using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.IdValuePair;

/// <summary>
/// A minimal Record type with an Id (string), Value (string)
/// </summary>
[PublicOpenApiObject]
public record IdValuePair
{
    /// <summary>
    /// Gets or sets id.
    /// </summary>
    [Required]
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public required string Id { get; init; } = null!;

    /// <summary>
    /// Gets or sets value.
    /// </summary>
    [Required]
    [JsonPropertyName("value")]
    [JsonProperty("value")]
    public required string Value { get; init; } = null!;
}