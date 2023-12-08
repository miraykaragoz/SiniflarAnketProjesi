using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarAnketProjesi.Models
{
    public class Question : BaseModel
    {
        public string Content { get; set; }
        public int SurveyId { get; set; }
        public int Order { get; set; }
        //navigational property
        public virtual Survey Survey { get; set; }
        public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}
