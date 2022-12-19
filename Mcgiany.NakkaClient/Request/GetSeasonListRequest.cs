using System.Text.Json.Serialization;
using Mcgiany.NakkaClient.Enums;

namespace Mcgiany.NakkaClient.Request;

/// <summary>
/// Get season list request - league tournaments.
/// </summary>
public class GetSeasonListRequest
{
    /// <summary>
    /// Count of skiped items.
    /// </summary>
    [JsonPropertyName("skip")]
    public int Skip { get; set; }

    /// <summary>
    /// Count of read items.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// Keyword filter.
    /// </summary>
    [JsonPropertyName("keyword")]
    public string Keyword { get; set; } = null!;

    /// <summary>
    /// Status filter.
    /// </summary>
    [JsonPropertyName("status")]
    public NakkaStatus[] Statuses { get; set; } = null!;

    /// <summary>
    /// Sort key.
    /// </summary>
    [JsonPropertyName("sort")]
    public string Sort { get; set; } = null!;
}
