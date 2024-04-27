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
    public class ProductController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var datas = GetProducts();

            List<ProductVM> products = new List<ProductVM>();

            foreach (var item in datas)
            {
                products.Add(new ProductVM
                {
                    Name = item.Name,
                    Price = item.Price,
                    Count = item.Count,
                    Description = item.Description
                });

            }
            return View(products);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product
                {
                    Id=1,
                    Name="Samsung",
                    Count=10,
                    Price=2000,
                    Description="Fast speed"
                },
                 new Product
                {
                    Id=2,
                    Name="Iphone",
                    Count=15,
                    Price=2500,
                    Description="Quality camera"
                },

            };
        }
    }
}

