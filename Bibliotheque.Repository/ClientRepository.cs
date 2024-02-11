using Bibliotheque.Entity;
using Database;
using Microsoft.EntityFrameworkCore;

namespace Bibliotheque.Repository;

public class ClientRepository : IClientRepository
{
    private readonly ApiContext _apiContext;

    public ClientRepository(ApiContext apiContext)
    {
        this._apiContext = apiContext;
    }
    
    public async Task<IResponseModel> CreateAsync(Client client)
    {
        _apiContext.Clients.Add(client);
        return await _apiContext.SaveChangesAsync() == 1
            ? new ResponseModel { Success = true }
            : new ResponseModel
            {
                Success = false
            };
    }
}