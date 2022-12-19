using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Request;

/// <summary>
/// Get match request.
/// </summary>
public class GetMatchRequest
{
    /// <summary>
    /// Match ID - represent as TMID in Nakka APP.
    /// </summary>
    [JsonPropertyName("tmid")]
    public string MatchId { get; set; } = null!;
}
