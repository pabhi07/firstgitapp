using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace WebApisample.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (NorthwindEntities entities = new NorthwindEntities())
            {
                return entities.Employees.ToList();

            }
        }
        public Employee Get(int id)
        {
            using (NorthwindEntities  entities = new NorthwindEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.EmployeeID == id);
            
        }
    }
}
    }
