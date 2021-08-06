using DatabaseAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLayer.Data.Interfaces
{
    interface IClientRepository
    {
        Task<Client> GetClientByIdAsync(int id);
        Task<List<Client>> GetClientsAsync();
        Task<int> CreateClientAsync(Client client);
        Task UpdateClient(int id, Client client);
        Task DeleteClient(int id);

    }
}
