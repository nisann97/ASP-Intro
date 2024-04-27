using System;
using HW_intro.Models;
using HW_intro.ViewModels;
using HW_intro.ViewModels.Student;
using Microsoft.AspNetCore.Mvc;

namespace HW_intro.Controllers
{
	public class HomeController : Controller
	{

		//public int GetNum()
		//{
		//	return 100;
		//}


  //      public string Search(string searchText)
  //      {
  //          return searchText;
  //      }

		public IActionResult Index()
		{
            //List<string> students = new List<string> { "Tunzale", "Semed", "Nise" };

            var datas = GetAllStudents();

			List<StudentVM> students = new List<StudentVM>();

			foreach(var item in datas)
			{
				students.Add(new StudentVM
				{
					FullName = item.FullName
				});
			}



			Book book = new()
			{
				Id = 1,
				Name = "Nisenin kitabi"
			};


			HomeVM model = new()
			{
				Students = students,
				Book = book
			};


            return View(model);
		}


		private List<Student> GetAllStudents()
		{

			return new List<Student>
			{
				new()
				{
					Id = 1,
					FullName = "Tunzale Memmedova",
					Age =22
				},

					new()
				{
					Id = 2,
					FullName = "Semed Huseynov",
					Age =28
				},

						new()
				{
					Id = 3,
					FullName = "Nurlan Musayev",
					Age =22
				}
			};
		}
    }
}

