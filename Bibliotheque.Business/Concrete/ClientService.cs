using Bibliotheque.Business.Abstract;
using Bibliotheque.Entity;

namespace Bibliotheque.Business.Concrete;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }
    
    public async Task<IResponseModel> CreateAsync(Client client)
    {
        var result = await _clientRepository.CreateAsync(client);
        return result.Success.Equals(true) ?
            new ResponseModel { Success = true } :
            new ResponseModel { Success = false };
    } 
}