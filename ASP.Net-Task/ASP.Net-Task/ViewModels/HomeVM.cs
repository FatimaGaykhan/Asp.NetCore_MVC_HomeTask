using System;
using ASP.Net_Task.Models;

namespace ASP.Net_Task.ViewModels
{
	public class HomeVM
	{
		public string Text { get; set; }

		public List<string> Students { get; set; }

		public int AgeOfAykhan { get; set; }

		public List<User> Users { get; set; }

	}
}

