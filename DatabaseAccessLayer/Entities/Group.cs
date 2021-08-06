using System.Collections.Generic;

namespace DatabaseAccessLayer.Entities
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }
        public List<ClientGroup> Clients { get; set; }
        
    }
}
