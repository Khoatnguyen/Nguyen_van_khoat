using PTPMQL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace PTPMQL.Controllers
{
    public class PersonController: Controller
    {
        public IActionResult Index()
        {
            List<Person> stdList = new List<Person>()
            {
                 new Person {PersonId=1, PersonName= "Nguyen Van A", Address= "So 9 Le van hien"},    
                  new Person {PersonId=2, PersonName= "Nguyen Van A1", Address= "So 91 Le van hien"},    
                   new Person {PersonId=3, PersonName= "Nguyen Van A2", Address= "So 92 Le van hien"},    
                    new Person {PersonId=4, PersonName= "Nguyen Van A3", Address= "So 93 Le van hien"},    
    
           };
           ViewData["Person"]= stdList;
        return View();
        }
        [HttpPost]
          public IActionResult Create(StudentController std)
    {
        // string message = std.StudentID +"-";
        // message += std.StudentName + "-";
        // mesage += std.Age;
        // ViewBag.TT = message;
        return View();
    }
    }

}
