using DatabaseAccessLayer.Data.Interfaces;
using DatabaseAccessLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseAccessLayer.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public Task<int> CreateClientAsync(Client client)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteClient(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Client> GetClientByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Client>> GetClientsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateClient(int id, Client client)
        {
            throw new System.NotImplementedException();
        }
    }
}
