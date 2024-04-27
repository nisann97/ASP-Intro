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
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var datas = GetAllUsers();

            List<UserVM> users = new List<UserVM>();

            foreach (var item in datas)
            {
                users.Add(new UserVM()
                {
                    FullName = item.FullName,
                    Address = item.Address,
                    Age= item.Age,
                    Email = item.Email

                });
            }
            return View(users);
        }

        private List<User> GetAllUsers()
        {

            return new List<User>()
            {
                new()
                {
                    Id = 1,
                    FullName = "Nisa Narimanova",
                    Address = "Yasamal",
                    Email = "nisann@gmail.com",
                    Age = 26
                },
                new()
                {
                    Id = 2,
                    FullName = "Arzu Kerimli",
                    Address ="Yasamal",
                    Email = "arzu@gmail.com",
                    Age = 26
                },

                new()
                {
                    Id = 3,
                    FullName = "Tunzale Memmedova",
                    Address = "Azadliq",
                    Email = "tunzale@gmail.com",
                    Age = 25
                }
            };


        }
    }
}

