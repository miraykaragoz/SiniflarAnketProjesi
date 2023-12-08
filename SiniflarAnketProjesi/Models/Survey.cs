using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarAnketProjesi.Models
{
    public class Survey : BaseModel
    {
        public string Title { get; set; }
        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
        public int SurveyTypeId { get; set; }
        public virtual SurveyType SurveyType { get; set; } 
    }
}
