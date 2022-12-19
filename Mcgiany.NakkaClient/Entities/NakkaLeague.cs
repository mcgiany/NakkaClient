using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Entities;

public class NakkaLeague
{
    [JsonPropertyName("lgid")]
    public string LeagueId { get; set; } = null!;

    [JsonPropertyName("createTime")]
    public long CreateTime { get; set; }

    [JsonPropertyName("updateTime")]
    public long UpdateTime { get; set; }

    [JsonPropertyName("ad")]
    public int Ad { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("details")]
    public string Details { get; set; } = null!;

    [JsonPropertyName("image")]
    public string Image { get; set; } = null!;

    [JsonPropertyName("color")]
    public string Color { get; set; } = null!;

    [JsonPropertyName("private")]
    public int Private { get; set; }

    [JsonPropertyName("co_admin_id")]
    public string CoadminId { get; set; } = null!;
}
