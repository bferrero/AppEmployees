using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BOL;

namespace Provider
{
    public class EmployeeProvider : BOL.Interfaces.IEmployee
    {
        public List<Employee> GetAll()
        {
            var comando = new Comando();

            DataTable dt = comando.ObjDataTable("Employee_GetAll");

            var list = new List<Employee>();

            list = (from DataRow dr in dt.Rows
                    select new Employee()
                    {
                        Id = Convert.ToInt64(dr["Id"]),
                        Name = dr["Name"].ToString(),
                        Type = new EmployeeType() { Id = Convert.ToInt64(dr["IdType"]), Name = dr["NameType"].ToString() },
                        Telephone = dr["Telephone"].ToString(),
                        Address = dr["Address"].ToString(),
                        EmployeeDate = Convert.ToDateTime(dr["EmployeeDate"])
                       
                    }).ToList();

            return list;
        }
    }
}
