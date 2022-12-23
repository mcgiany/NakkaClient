using System.Net.Http.Json;

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
    public async Task<TResponse?> PostAsync<TRequest, TResponse>(string url, TRequest request)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync(url, request);
            return await response.Content.ReadFromJsonAsync<TResponse>();
        }
        catch (Exception e)
        {
            throw new InvalidCastException($"Cannot get response from {url} to type {typeof(TResponse)}", e);
        }
    }

    /// <summary>
    /// Makes HTTP GET request to URL.
    /// </summary>
    /// <typeparam name="TResponse">Type of expected GET response.</typeparam>
    /// <param name="url">GET URL.</param>
    /// <returns>Response deserialized as TResponse.</returns>
    /// <exception cref="InvalidCastException">When deserialized object is null.</exception>
    public async Task<TResponse?> GetAsync<TResponse>(string url)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<TResponse>(url);
        }
        catch (Exception e)
        {
            throw new InvalidCastException($"Cannot get response from {url} to type {typeof(TResponse)}", e);
        }
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
    }
}