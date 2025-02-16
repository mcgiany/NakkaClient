using System.Text.Json;
using System.Text.Json.Serialization;
using Mcgiany.NakkaClient.Entities;

namespace Mcgiany.NakkaClient.Converters;

public class BadgeJsonConverter : JsonConverter<Dictionary<string, Badge>>
{
    public override Dictionary<string, Badge>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        try
        {
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {}
                return null;
            }
            return JsonSerializer.Deserialize<Dictionary<string, Badge>>(ref reader);
        }
        catch
        {
            return null;
        }
    }

    public override void Write(Utf8JsonWriter writer, Dictionary<string, Badge> value, JsonSerializerOptions options)
    {
        
    }
}
