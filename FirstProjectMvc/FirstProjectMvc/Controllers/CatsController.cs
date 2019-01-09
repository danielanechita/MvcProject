using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstProjectMvc.Controllers
{
	public class CatsController : Controller
	{
		// GET: /<controller>/
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult List(Colors? color, Genders? gender)
		{
			var cats = PopulateList();

			if (color.HasValue)
			{
				cats = cats.Where(x => x.Color == color.Value).ToList();
			}

			if(gender.HasValue)
			{
				cats = cats.Where(x => x.Gender == gender.Value).ToList();
			}

			return View(cats);
		}

		public List<Cat> PopulateList()
		{
			var cats = new List<Cat>();

			cats.Add(new Cat()
			{
				Gender = Genders.Female,
				Color = Colors.White,
				Age = 12
			});
			cats.Add(new Cat()
			{
				Gender = Genders.Female,
				Color = Colors.Black,
				Age = 12
			});
			cats.Add(new Cat()
			{
				Gender = Genders.Male,
				Color = Colors.White,
				Age = 12
			});
			cats.Add(new Cat()
			{
				Gender = Genders.Male,
				Color = Colors.Yellow,
				Age = 12
			});

			return cats;
		}
	}
}
