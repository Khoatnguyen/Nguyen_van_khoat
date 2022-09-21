using PTPMQL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace PTPMQL.Controllers
{
    public class EmployeeController: Controller
    {
        public IActionResult Index()
        {
            List<Employee> stdList = new List<Employee>()
            {
                 new Employee {EmployeeID=1, EmployeeName= "Nguyen Van A", Age= 18},    
                 new Employee {EmployeeID=2, EmployeeName= "Nguyen Van f", Age= 18},    
                 new Employee {EmployeeID=3, EmployeeName= "Nguyen Van e", Age= 18},    
           };
           ViewData["Employee"]= stdList;
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
