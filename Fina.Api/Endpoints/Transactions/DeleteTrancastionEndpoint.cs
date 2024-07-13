﻿using Fina.Api.Common.Api;
using Fina.Core.Handlers;
using Fina.Core.Models;
using Fina.Core.Requests.Transactions;
using Fina.Core.Responses;

namespace Fina.Api.Endpoints.Transactions;

public class DeleteTrancastionEndpoint : IEndPoint
{
    public static void Map(IEndpointRouteBuilder app)
    {
        app.MapDelete("/{id}", HandleAsync)
            .WithName("Transactions: Delete")
            .WithSummary("Excluir uma transação")
            .WithDescription("Excluir uma transação")
            .WithOrder(3)
            .Produces<Response<Transaction?>>();
    }

    private static async Task<IResult> HandleAsync(
        ITransactionHandler handler,
        long id)
    {
        var request = new DeleteTransactionRequest()
        {
            UserId = ApiConfiguration.UserId,
            Id = id
        };
        

        var result = await handler.DeleteAsync(request);
        return result.IsSuccess
            ? TypedResults.Ok(result)
            : TypedResults.BadRequest(result);
    }
}
