using System;
using Homework_1st.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework_1st.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var datas = GetAllUsers();

            return View(datas);
        }

        private List<User> GetAllUsers()
        {

            return new List<User>
            {
                new()
                {
                    Id = 1,
                    FullName = "Nisa Narimanova",
                    Email = "nisann@gmail.com",
                    Age = 26


                },

                new()
                {
                    Id = 2,
                    FullName = "Arzu Kerimli",
                    Email = "arzu@gmail.com",
                    Age = 26
                },

                new()
                {
                    Id = 3,
                    FullName = "Tunzale Memmedova",
                    Email = "tunzale@gmail.com",
                    Age = 25
                }
            };

        }
    }
}

