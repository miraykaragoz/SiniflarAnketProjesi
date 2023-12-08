using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarAnketProjesi.Models
{
    public class CustomerContactPerson : BaseModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; } 
    }
}
