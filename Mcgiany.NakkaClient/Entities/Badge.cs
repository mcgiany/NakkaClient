using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Entities;

public class Badge
{

    [JsonPropertyName("str")]
    public string Name { get; set; } = null!;
}
