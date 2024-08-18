using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Entity_Framework.Classes
{
    public class StudCourse
    {
        public int StudCourseId { get; set; }
        public int StudId { get; set; }
        public int CourseId { get; set; }
        public string Grade { get; set; }
    }
}
