using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Request;

/// <summary>
/// Get league request.
/// </summary>
public class GetLeagueRequest
{
    /// <summary>
    /// League ID - represent as LGID in Nakka APP.
    /// </summary>
    [JsonPropertyName("lgid")]
    public string LeagueId { get; set; } = null!;
}
