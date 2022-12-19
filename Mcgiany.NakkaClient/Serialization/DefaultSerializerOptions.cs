using System.Text.Json;

namespace Mcgiany.NakkaClient.Serialization;

/// <summary>
/// Default serializer options.
/// </summary>
public static class DefaultSerializerOptions
{
    private static JsonSerializerOptions _options = null!;

    /// <summary>
    /// Get options.
    /// </summary>
    /// <returns><see cref="JsonSerializerOptions"/></returns>
    public static JsonSerializerOptions Get()
    {
        return _options ??= new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

    }
}
