using Microsoft.AspNetCore.Mvc;
using NguyenThiKhamBTH.Models;
using PTPM.Models;

namespace NguyenThiKhamBTH.Controllers
{
    public class EmployeeController : Controller
    {
        // Viết các phương thức
        public IActionResult Index(Employee std )
        {
           ViewBag.Ep = std.EmployeeID +"-"+ std.EmployeeName +"-"+ std.EmployeeAge;
       
            return View();
        }
        // khoi tao list Person
        public IActionResult KH(){
    List<Employee> stdList = new List<Employee>()
     {
        new Employee {EmployeeID = 1, EmployeeName  = "Nguyen Van A", EmployeeAge = 19},
        new Employee {EmployeeID = 2, EmployeeName  = "Nguyen Van B", EmployeeAge = 20},
        new Employee {EmployeeID = 3, EmployeeName  = "Nguyen Van C", EmployeeAge = 21},
        new Employee {EmployeeID = 4, EmployeeName  = "Nguyen Van D", EmployeeAge = 22},
        new Employee {EmployeeID = 5, EmployeeName  = "Nguyen Van E", EmployeeAge = 23},
     };
     ViewData["Employees"] = stdList;
    return View(stdList);
    }
    

        public IActionResult Create(Employee std)
    
        {
            
            string message = std.EmployeeID + "-";
            message += std.EmployeeName + "-";
            message += std.EmployeeAge;
            ViewBag.TT = message;
            return View();
           
        }
        
    }
    
}