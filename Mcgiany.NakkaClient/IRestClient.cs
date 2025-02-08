namespace Mcgiany.NakkaClient;

public interface IRestClient : IDisposable
{
    /// <summary>
    /// Makes HTTP POST request to URL.
    /// </summary>
    /// <typeparam name="TRequest">Type of POST request.</typeparam>
    /// <typeparam name="TResponse">Type of expected POST response.</typeparam>
    /// <param name="url">POST URL.</param>
    /// <param name="request">Request data.</param>
    /// <returns>Response deserialized as TResponse.</returns>
    /// <exception cref="InvalidCastException">When deserialized object is null.</exception>
    Task<TResponse?> PostAsync<TRequest, TResponse>(string url, TRequest request);

    /// <summary>
    /// Makes HTTP GET request to URL.
    /// </summary>
    /// <typeparam name="TResponse">Type of expected GET response.</typeparam>
    /// <param name="url">GET URL.</param>
    /// <returns>Response deserialized as TResponse.</returns>
    /// <exception cref="InvalidCastException">When deserialized object is null.</exception>
    Task<TResponse?> GetAsync<TResponse>(string url);
}
