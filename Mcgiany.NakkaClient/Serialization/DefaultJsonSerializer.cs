using System.Text.Json;

namespace Mcgiany.NakkaClient.Serialization;

/// <summary>
/// Default JSON serializer.
/// </summary>
public class DefaultJsonSerializer
{
    /// <summary>
    /// Deserialize with default serializer options.
    /// </summary>
    /// <typeparam name="T">Type for deserialization.</typeparam>
    /// <param name="json">JSON to deserialize.</param>
    /// <returns></returns>
    public static T? Deserialize<T>(string json)
    {
        return JsonSerializer.Deserialize<T>(json, DefaultSerializerOptions.Get());
    }

    /// <summary>
    /// Serialize with default serializer options.
    /// </summary>
    /// <typeparam name="T">Type of serialized object.</typeparam>
    /// <param name="obj">Serialized object.</param>
    /// <returns></returns>
    public static string Serialize<T>(T obj)
    {
        return JsonSerializer.Serialize(obj, DefaultSerializerOptions.Get());
    }
}
