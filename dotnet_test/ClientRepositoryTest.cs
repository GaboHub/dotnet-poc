using System;
using Xunit;
using dotnet_api.Repository;
using dotnet_api.Modelo;
using System.Collections.Generic;
using System.Linq;


namespace dotnet_test
{
    public class ClientRepositoryTest
    {

        private readonly ClientRepository _clientRepository;

        public ClientRepositoryTest() {
            _clientRepository = new ClientRepository();
        }
        [Fact]
        public void givenClientRepositoryShouldReturn4MockedClients()
        {
            List<Client> expected = new List<Client>()
            {
                new Client{ id=1, nombre="test", apellido="test"},
                new Client{ id=2, nombre="test2", apellido="test2"},
                new Client{ id=3, nombre="test3", apellido="test3"},
                new Client{ id=4, nombre="test4", apellido="test4"},
            };

            Assert.Equal(expected, _clientRepository.GetClients());
            
        }
    }

}
