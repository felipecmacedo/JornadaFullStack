using Fina.Core.Requests.Transactions;
using Fina.Core.Responses;
using System.Transactions;

namespace Fina.Core.Handlers;

public interface ITransactionHandler
{
    Task<Response<Transaction?>> CreateAsync(CreateTransactionRequest request);
    Task<Response<Transaction?>> UpdateAsync(UpdateTransactionRequest request);
    Task<Response<Transaction?>> DeleteAsync(DeleteTransactionRequest request);
    Task<Response<Transaction?>> GetIdAsync(GetTransactionById request);
    Task<PagedResponse<List<Transaction>?>> GetPeriodAsync(GetTransactionsByPeriodRequest request);
}
