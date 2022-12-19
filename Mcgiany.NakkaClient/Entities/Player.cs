using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Entities;

/// <summary>
/// Nakka player.
/// </summary>
public class Player
{
    /// <summary>
    /// PLayer ID.
    /// </summary>
    [JsonPropertyName("tpid")]
    public string PlayerId { get; set; } = null!;

    /// <summary>
    /// Player name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
}
