using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Entity_Framework.Classes
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InsId { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
