using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetCore_HomeTask.Models;
using Asp.NetCore_HomeTask.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace Asp.NetCore_HomeTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeVM model = new()
            {
                Students = GetAllStudents(),
                Products=GetAllProducts(),
                StudentsByDesc=GetAllStudentsByDesc(),
                ProductsCount=GetProductsCount()
            };


            return View(model);
        }

        private List<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Name="Fatima",
                    Surname="Gaykhanova",
                    Age=22,
                    Email="fatimaeg@code.edu.az",
                    PhoneNumber="0773130550"
                },
                new Student
                {
                    Name="Sadigkhan",
                    Surname="Gaykhanov",
                    Age=26,
                    Email="sadigkhaneg@code.edu.az",
                    PhoneNumber="0519252121"
                },
                new Student
                {
                    Name="Faxriyya",
                    Surname="Tagizade",
                    Age=22,
                    Email="faxriyyat@code.edu.az",
                    PhoneNumber="86759302"
                },
                new Student
                {
                    Name="Rashad",
                    Surname="Agayev",
                    Age=21,
                    Email="rashad@code.edu.az",
                    PhoneNumber="2647482924"
                }
            };
        }

        private List<Student> GetAllStudentsByDesc()
        {
            List<Student> students = GetAllStudents();

            List<Student> sortedStudents = students.OrderByDescending(m => m.Age).ToList();

            return sortedStudents;
        }

        private int GetProductsCount()
        {
            int count = 0;

            List<Product> products = GetAllProducts();

            count = products.Count;

            return count;
        }

        private List<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Name="Iphone 15 pro max",
                    Price=4500,
                    Color="Silver"
                },
                new Product
                {
                    Name="Samsung Galaxy",
                    Price=3800,
                    Color="Gold"
                },
                new Product
                {
                    Name="BlackBerry",
                    Price=2300,
                    Color="Black"
                },
            };
        }
    }
}

