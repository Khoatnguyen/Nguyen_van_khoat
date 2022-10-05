using System;
using PTPMQL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace PTPMQL.Controllers{
    public class DeleteWhite : Controller {
     StringProcess rmw = new StringProcess();
     public IActionResult Index(){
        return View();
    }
    [HttpPost]
    public IActionResult Index( string strInput){
       string str = rmw.RemoveRemainingWhiteSpace(strInput);
        ViewBag.deleteWhite= str;
       return View();
    }

    }
}