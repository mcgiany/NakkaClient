using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Entities;

public class MatchStatsData
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("Tid")]
    public string Tid { get; set; } = null!;

    [JsonPropertyName("sname")]
    public string Sname { get; set; } = null!;

    [JsonPropertyName("fid")]
    public string Fid { get; set; } = null!;

    [JsonPropertyName("gid")]
    public string Gid { get; set; } = null!;

    [JsonPropertyName("country")]
    public string Country { get; set; } = null!;

    [JsonPropertyName("pid")]
    public string Pid { get; set; } = null!;

    [JsonPropertyName("tpid")]
    public string Tpid { get; set; } = null!;

    [JsonPropertyName("me")]
    public int Me { get; set; }

    [JsonPropertyName("winSets")]
    public int WinSets { get; set; }

    [JsonPropertyName("winLegs")]
    public int WinLegs { get; set; }

    [JsonPropertyName("allScore")]
    public int AllScore { get; set; }

    [JsonPropertyName("allDarts")]
    public int AllDarts { get; set; }
}
