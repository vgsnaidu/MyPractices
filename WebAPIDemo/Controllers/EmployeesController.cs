using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class EmployeesController : ApiController
    {
        Employee[] employees = new Employee[]
        {
            new Employee{ID=1,Name="Name1",JoiningDate=DateTime.Parse(DateTime.Today.ToString()),Age=20},
            new Employee{ID=2,Name="Name2",JoiningDate=DateTime.Parse(DateTime.Today.ToString()),Age=22},
            new Employee{ID=3,Name="Name3",JoiningDate=DateTime.Parse(DateTime.Today.ToString()),Age=23}
        };

        public IEnumerable<Employee> GetEmployees()
        {
            return employees;
        }
        public IHttpActionResult GetEmployee(int id)
        {
            var employee = employees.FirstOrDefault(x => x.ID == id);
            if (employee == null)
                return NotFound();
            else
                return Ok(employee);
        }
    }
}
