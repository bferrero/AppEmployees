using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public EmployeeType Type { get; set; }
        public string Telephone { get; set; }

        public string Address { get; set; }

        public DateTime EmployeeDate { get; set; }
    }
}
