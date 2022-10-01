using Microsoft.AspNetCore.Mvc;
using NguyenThiKhamBTH.Models;
using PTPM.Models;

namespace NguyenThiKhamBTH.Controllers
{
   public class PersonController : Controller
   {
    
    public IActionResult Index(Person std)
    {
       ViewBag.AP = std.PersonID +"_"+ std.Personstring +"_"+ std.PersonAge;
        return View();
        }
    public IActionResult list()
{
    // khoi tao list Person
    List<Person> stdList = new List<Person>()
     {
        new Person {PersonID = 1, Personstring  = "Nguyen Thi A", PersonAge = 19},
        new Person {PersonID = 2, Personstring  = "Nguyen Thi B", PersonAge = 20},
        new Person {PersonID = 3, Personstring  = "Nguyen Thi C", PersonAge = 21},
        new Person {PersonID = 4, Personstring  = "Nguyen Thi D", PersonAge = 22},
        new Person {PersonID = 5, Personstring  = "Nguyen Thi E", PersonAge = 23},
     };
     ViewData["Persons"] = stdList;
    return View(stdList);
    }
    [HttpPost]
    public IActionResult Creat(Person std)
    {
            string message = std.PersonID + "-";
            message += std.Personstring + "-";
            message += std.PersonAge;
            ViewBag.TT = message;
            return View();

    }
   }
}