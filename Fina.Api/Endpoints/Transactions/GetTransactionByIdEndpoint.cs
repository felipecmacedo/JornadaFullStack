using Fina.Api.Common.Api;
using Fina.Core.Handlers;
using Fina.Core.Models;
using Fina.Core.Requests.Transactions;
using Fina.Core.Responses;

namespace Fina.Api.Endpoints.Transactions;

public class GetTransactionByIdEndpoint : IEndPoint
{
    public static void Map(IEndpointRouteBuilder app)
    {
        app.MapGet("/{id}", HandleAsync)
            .WithName("Transactions: Get by id")
            .WithSummary("Recuperar uma transação")
            .WithDescription("Recuperar uma transação")
            .WithOrder(4)
            .Produces<Response<Transaction?>>();
    }

    private static async Task<IResult> HandleAsync(
        ITransactionHandler handler,
        long id)
    {
        var request = new GetTransactionByIdRequest
        {
            UserId = ApiConfiguration.UserId,
            Id = id
        };

        var result = await handler.GetIdAsync(request);
        return result.IsSuccess
            ? TypedResults.Ok(result)
            : TypedResults.BadRequest(result);
    }
}
