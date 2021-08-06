using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLayer.Entities
{
   public class Client
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }

        public int PhoneNumber { get; set; }
        public string PasswordHash { get; set; }

        public List<ClientGroup> Groups { get; set; }

    }
}
