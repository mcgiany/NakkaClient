using Mcgiany.NakkaClient.Serialization;
using System.Text;

namespace Mcgiany.NakkaClient.Http;

/// <summary>
/// Rest client for HTTP request and deserialize responses.
/// </summary>
public class RestClient : IDisposable
{
    private readonly HttpClient _httpClient;

    public RestClient()
    {
        _httpClient = new HttpClient();
    }

    /// <summary>
    /// Makes HTTP POST request to URL.
    /// </summary>
    /// <typeparam name="TRequest">Type of POST request.</typeparam>
    /// <typeparam name="TResponse">Type of expected POST response.</typeparam>
    /// <param name="url">POST URL.</param>
    /// <param name="request">Request data.</param>
    /// <returns>Response deserialized as TResponse.</returns>
    /// <exception cref="InvalidCastException">When deserialized object is null.</exception>
    public async Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest request)
    {
        var serializedRequest = DefaultJsonSerializer.Serialize(request);
        var message = new StringContent(serializedRequest, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(url, message);
        var responseContent = await response.Content.ReadAsStringAsync();
        var deserializedResponse = DefaultJsonSerializer.Deserialize<TResponse>(responseContent);
        if (deserializedResponse == null)
        {
            throw new InvalidCastException($"Cannot deserialize response from {url} to type {typeof(TResponse)}");
        }
        return deserializedResponse;
    }

    /// <summary>
    /// Makes HTTP GET request to URL.
    /// </summary>
    /// <typeparam name="TResponse">Type of expected GET response.</typeparam>
    /// <param name="url">GET URL.</param>
    /// <returns>Response deserialized as TResponse.</returns>
    /// <exception cref="InvalidCastException">When deserialized object is null.</exception>
    public async Task<TResponse> GetAsync<TResponse>(string url)
    {
        var response = await _httpClient.GetAsync(url);
        var responseContent = await response.Content.ReadAsStringAsync();
        var deserializedResponse = DefaultJsonSerializer.Deserialize<TResponse>(responseContent);
        if (deserializedResponse == null)
        {
            throw new InvalidCastException($"Cannot deserialize response from {url} to type {typeof(TResponse)}");
        }
        return deserializedResponse;
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
    }
}