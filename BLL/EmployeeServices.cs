using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using Provider;

namespace BLL
{
    public class EmployeeServices : BOL.Interfaces.IEmployee
    {
        private EmployeeProvider _myProvider;

        public EmployeeServices() {

            _myProvider = new EmployeeProvider();
        }
        public List<Employee> GetAll()
        {
            return _myProvider.GetAll();
        }
    }
}
