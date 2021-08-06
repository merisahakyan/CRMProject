using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLayer.Entities
{
    public class EmailTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreationDate{ get; set; }
    }

}
