using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Jellyfin.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Jellyfin.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class JellyfinOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="JellyfinOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddJellyfinOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IJellyfinOpenApiHttpClient, JellyfinOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="JellyfinOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddJellyfinOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IJellyfinOpenApiHttpClient, JellyfinOpenApiHttpClient>();

        return services;
    }
}
