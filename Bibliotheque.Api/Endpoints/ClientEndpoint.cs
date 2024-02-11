using Bibliotheque.Business.Abstract;
using Bibliotheque.Entity;

namespace Bibliotheque.Api.Endpoints;

public static class ClientEndpoint
{
   public static void MapClient(this IEndpointRouteBuilder app)
   {
      app.MapPost("/client", CreateClient)
         .Produces<IResult>()
         .Produces(StatusCodes.Status200OK);
   }
   
   static async Task<IResult> CreateClient(Client client,IClientService clientService)
   {
      var result = await clientService.CreateAsync(client);
      return result.Success ? TypedResults.Created($"/client/{client.Id}", result) : TypedResults.BadRequest(result);
   }
}