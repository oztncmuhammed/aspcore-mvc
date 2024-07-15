using Microsoft.AspNetCore.Mvc;
using Basics.Models;

namespace Basics.Controllers
{
    public class EmployeeController:Controller
    {
        
        public IActionResult Index1 ()
        {   
            string message=$"Hello World. {DateTime.Now.ToString()}";
            return View("Index1",message);
        }

        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Ahmet",
                "Can",
                "Mehmet"
            };
            return View(names);
        }

        public IActionResult Index3()
        {   
            var list = new List<Employee>()
            {
                new Employee(){Id=1,FirstName="Muhammed",LastName="Oztunc",Age =23},
                new Employee(){Id=1,FirstName="Fedile",LastName="Oztunc",Age =48},
            };
            return View("Index3",list);
        }
    }
}