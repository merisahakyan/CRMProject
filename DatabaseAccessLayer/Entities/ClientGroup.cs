using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLayer.Entities
{
    public class ClientGroup
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }



    }
}
