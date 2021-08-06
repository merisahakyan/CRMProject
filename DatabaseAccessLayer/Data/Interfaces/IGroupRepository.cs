using DatabaseAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLayer.Data.Interfaces
{
    public interface IGroupRepository
    {
        Task<Group> GetGroupByIdAsync(int id);
        Task<List<Group>> GetGroupsAsync();
        Task<int> CreateGroupAsync(Group group);
        Task UpdateGroup(int id, Group group);
        Task DeleteGroup(int id);

    }
}
