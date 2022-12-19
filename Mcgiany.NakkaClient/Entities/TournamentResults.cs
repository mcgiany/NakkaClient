using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Entities;

public class TournamentResults
{
    [JsonPropertyName("time")]
    public long Time { get; set; }

    [JsonPropertyName("list")]
    public TournamentResultItem[] List { get; set; } = null!;
}
