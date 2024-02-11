namespace Bibliotheque.Entity;

public interface IClientRepository
{
    Task<IResponseModel> CreateAsync(Client client);
}