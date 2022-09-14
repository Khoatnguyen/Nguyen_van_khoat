using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using PTPMQL.Models;
namespace PTPMQL.Controllers
{
    public class StudentController : Controller
    {
        // 
        // GET: /HelloWorld/
       public IActionResult Index()
    {
        //Khoiwjtaor list student
        List<Student> stdList=new List<Student>()
        {
            new Student {StudentID=1, StudentName= "Nguyen Van A", Age= 18},
            new Student {StudentID=2, StudentName="Nguyen Van B", Age=18},
            new Student {StudentID=3, StudentName="Nguyen Van C", Age=18},
            new Student {StudentID=4, StudentName="Nguyen Van D", Age=18},
            new Student {StudentID=5, StudentName="Nguyen Van E", Age=18},
            new Student {StudentID=6, StudentName="Nguyen Van F", Age=18},
        };
        ViewData["Student"]= stdList;
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
        

        // 
        // GET: /HelloWorld/Welcome/ 

            public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}