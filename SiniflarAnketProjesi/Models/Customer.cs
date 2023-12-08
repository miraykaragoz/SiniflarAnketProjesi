using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarAnketProjesi.Models
{
    public class Customer : BaseModel
    {
        public string Name { get; set; } 
        public ICollection<CustomerContactPerson> Contacts { get; set; } = new List<CustomerContactPerson>();
    }
}
