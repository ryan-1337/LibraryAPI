using Bibliotheque.Api.Endpoints;

namespace Bibliotheque.Api;

public static class MapEndpoints
{
    public static IEndpointRouteBuilder MapEndpoint(this IEndpointRouteBuilder group)
    {
        group.MapClient();
        return group;
    }
}