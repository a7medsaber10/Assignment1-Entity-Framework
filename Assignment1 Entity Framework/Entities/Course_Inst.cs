using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Entity_Framework.Classes
{
    public class CourseInst
    {
        public int CourseInstId { get; set; }
        public int InstId { get; set; }
        public int CourseId { get; set; }
        public int Evaluate { get; set; }
    }
}
