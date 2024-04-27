using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework_1st.Models;
using Homework_1st.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Homework_1st.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var datas = GetAllEmployees();
            List<EmployeeVM> employees = new List<EmployeeVM>();

            foreach (var item in datas)
            {
                employees.Add(new EmployeeVM
                {
                    Name = item.Name,
                    Surname = item.Surname,
                    Age= item.Age,
                    Salary = item.Salary
                });
            }

            return View(employees);
        }

        private List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    Id = 1,
                    Name = "Nisa",
                    Surname = "Narimanova",
                    Salary = 3000,
                    Age = 26
                },
                    new Employee
                {
                    Id = 2,
                    Name = "Arzu",
                    Surname = "Kerimli",
                    Salary = 3000,
                    Age = 26
                },
                        new Employee
                {
                    Id = 1,
                    Name = "Rufana",
                    Surname = "Ahmadova",
                    Salary = 2800,
                    Age = 32
                },
            };
        }
    }
}

