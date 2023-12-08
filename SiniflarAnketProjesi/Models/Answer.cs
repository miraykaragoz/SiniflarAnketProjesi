using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarAnketProjesi.Models
{
    public class Answer : BaseModel
    {
        public string? Description { get; set; }
        public int OptionId {  get; set; }
        public virtual Option Option { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; } 
        public int? CustomerContactPersonId { get; set; }
        public virtual CustomerContactPerson? CustomerContactPerson { get; set; }
        public int? EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
        public string IpAdress {  get; set; } 
    }
}
