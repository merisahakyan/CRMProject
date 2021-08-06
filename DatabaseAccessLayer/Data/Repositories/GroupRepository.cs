using DatabaseAccessLayer.Data.Interfaces;
using DatabaseAccessLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseAccessLayer.Data.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        public Task<int> CreateGroupAsync(Group group)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteGroup(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Group> GetGroupByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Group>> GetGroupsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateGroup(int id, Group group)
        {
            throw new System.NotImplementedException();
        }
    }
}
