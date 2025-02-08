using Mcgiany.NakkaClient.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Mcgiany.NakkaClient.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddNakkaClient(this IServiceCollection services, string baseUrl = "https://tk2-228-23746.vs.sakura.ne.jp/n01/")
    {
        ArgumentException.ThrowIfNullOrEmpty(baseUrl);
        services.AddHttpClient("RestClient", o => o.BaseAddress = new Uri(baseUrl));
        services.AddScoped<IRestClient, RestClient>();
        services.AddScoped<INakkaClient, NakkaClient>();
        return services;
    }
}
