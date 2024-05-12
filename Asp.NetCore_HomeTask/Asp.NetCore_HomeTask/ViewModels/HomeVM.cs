using System;
using Asp.NetCore_HomeTask.Models;

namespace Asp.NetCore_HomeTask.ViewModels
{
	public class HomeVM
	{
		public List<Student> Students { get; set; }

		public List<Product> Products { get; set; }

		public List<Student> StudentsByDesc { get; set; }

		public int ProductsCount { get; set; }

	}
}

