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
    public class BookController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var datas = GetAllBooks();

            List<BookVM> books = new List<BookVM>();

            foreach (var item in datas)
            {
                books.Add(new BookVM
                {
                    Name = item.Name
                });
            }
            return View(books);
        }

        private List<Book> GetAllBooks()
        {
            return new List<Book>()
            {
                new Book
                {
                    Id=1,
                    Name="Outliers"

                },
                  new Book
                {
                    Id=2,
                    Name="Felsefenin kisa tarihi"

                },
            };
        }
    }
}

