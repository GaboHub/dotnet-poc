using dotnet_api.Modelo;
using dotnet_api.Repository;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_api.Services
{
    public class ClientService {
        private readonly ClientRepository _clientRepository;

        public ClientService(ClientRepository _clientRepository)
        {
            this._clientRepository = _clientRepository;
        }

         public IEnumerable<Client> GetClients()
        {
            return _clientRepository.GetClients();
        }

         public Client GetClient(int id)
        {
            return _clientRepository.getClient(id);
        }

        public void AddClient(Client newClient)
        {
            _clientRepository.AddClient(newClient);
        }
    }
}