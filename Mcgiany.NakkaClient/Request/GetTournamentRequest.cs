using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Request;

/// <summary>
/// Get tournament request.
/// </summary>
public class GetTournamentRequest
{
    /// <summary>
    /// Tournament ID - represent as TDID in Nakka APP.
    /// </summary>
    [JsonPropertyName("tdid")]
    public string TournamentId { get; set; } = null!;
}
