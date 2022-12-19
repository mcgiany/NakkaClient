using System.Text.Json.Serialization;
using Mcgiany.NakkaClient.Enums;

namespace Mcgiany.NakkaClient.Entities;

public class NakkaRound
{
    /// <summary>
    /// Tournament ID.
    /// </summary>
    [JsonPropertyName("tdid")]
    public string TournamentId { get; set; } = null!;

    /// <summary>
    /// Tournament created.
    /// </summary>
    [JsonPropertyName("createTime")]
    public long CreateTime { get; set; }

    /// <summary>
    /// Tournament title.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Date of tournament.
    /// </summary>
    [JsonPropertyName("t_date")]
    public long TournamentDate { get; set; }

    /// <summary>
    /// Tournament status.
    /// </summary>
    [JsonPropertyName("status")]
    public NakkaStatus Status { get; set; }
}
