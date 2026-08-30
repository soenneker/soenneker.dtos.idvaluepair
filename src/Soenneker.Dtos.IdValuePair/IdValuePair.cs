using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.IdValuePair;

/// <summary>
/// Associates a required string identifier with a required string value.
/// </summary>
[PublicOpenApiObject]
public record IdValuePair
{
    /// <summary>
    /// Gets the identifier for the value.
    /// </summary>
    [Required]
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public required string Id { get; init; } = null!;

    /// <summary>
    /// Gets the value associated with <see cref="Id"/>.
    /// </summary>
    [Required]
    [JsonPropertyName("value")]
    [JsonProperty("value")]
    public required string Value { get; init; } = null!;
}
