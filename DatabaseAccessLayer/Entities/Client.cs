using System.Collections.Generic;

namespace DatabaseAccessLayer.Entities
{
    public class Client : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public List<ClientGroup> Groups { get; set; }
    }
}
