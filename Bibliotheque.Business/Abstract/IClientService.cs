using Bibliotheque.Entity;

namespace Bibliotheque.Business.Abstract;

public interface IClientService
{
    Task<IResponseModel> CreateAsync(Client client);
}