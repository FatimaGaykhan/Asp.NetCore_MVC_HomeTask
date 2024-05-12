using System;
using ASP.Net_Task.Models;
using ASP.Net_Task.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Task.Controllers
{
	public class HomeController:Controller
	{
		public IActionResult Index()
		{
            List<string> students = new List<string> { "Amirastan", "Fexriyye", "Elmir", "Ilqar", "Nurlan" };
			string text = "Welcome";
			int ageOfAykhan = 24;

			HomeVM model = new()
			{
				Text = text,
				Students = students,
				AgeOfAykhan = ageOfAykhan,
				Users=GetAllUsers()
			};
            return View(model);
		}

		private List<User> GetAllUsers()
		{
			return new List<User>
			{
				new User
				{
					Id=1,
					Age=100
				},
				new User
				{
					Id=2,
					Age=50
				}
			};
		}


	}
}

