using System.Collections.Generic;
using System.Linq;

using dotnet_api.Modelo;

namespace dotnet_api.Repository
{
    public class ClientRepository {
        private static List<Client> _listaClientes = new List<Client>()
        {
            new Client{ id=1, nombre="test", apellido="test"},
            new Client{ id=2, nombre="test2", apellido="test2"},
            new Client{ id=3, nombre="test3", apellido="test3"},
            new Client{ id=4, nombre="test4", apellido="test4"},
        };

         public IEnumerable<Client> GetClients()
        {
            return _listaClientes;
        }

        public Client getClient(int id)
        {
            var cliente = _listaClientes.Where(cli => cli.id == id);

            return cliente.FirstOrDefault();
        }

        public void AddClient(Client newClient)
        {
            _listaClientes.Add(newClient);
        }
    }
}