using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstProjectMvc.Controllers
{
	public class DogsController : Controller
	{
		// GET: /<controller>/
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult List(Colors? color,Genders? gender)
		{
			var dogs = PopulateList();
			if(color.HasValue)
			{
				dogs = dogs.Where(x => x.Color == color.Value).ToList();
			}
			if(gender.HasValue)
			{
				dogs = dogs.Where(x => x.Gender == gender.Value).ToList();
			}
			return View(dogs);
		}
		public List<Dog> PopulateList()
		{
			var dogs = new List<Dog>();

			dogs.Add(new Dog()
			{
				Gender = Genders.Male,
				Color = Colors.White,
				Age = 2

			});

			dogs.Add(new Dog()
			{
				Gender = Genders.Female,
				Color = Colors.Yellow,
				Age = 2

			});

			dogs.Add(new Dog()
			{
				Gender = Genders.Male,
				Color = Colors.Black,
				Age = 2

			});

			return dogs;


		}
	}
}
