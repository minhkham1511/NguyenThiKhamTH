using Microsoft.AspNetCore.Mvc;
using NguyenThiKhamBTH.Models;
namespace NguyenThiKhamBTH.Controllers 
{

  
  public class studentController: Controller
{
    //các action

[HttpPost]
 public IActionResult Index(student std)
{
    ViewBag.message = std.studentID+"-"+std.studentName+"-"+std.studentAge   ;
    return View();
}
    
public IActionResult list()
{
    
    // khoi tao list Student
    List<student> stdList = new List<student>()
     {
        new student {studentID = 1, studentName  = "Nguyen Van A", studentAge = 18},
        new student {studentID = 2, studentName  = "Nguyen Van B", studentAge = 18},
        new student {studentID = 3, studentName  = "Nguyen Van C", studentAge = 18},
        new student {studentID = 4, studentName  = "Nguyen Van D", studentAge = 18},
        new student {studentID = 5, studentName  = "Nguyen Van E", studentAge = 18},
     };
     ViewData["Students"] = stdList;
    return View(stdList);
}
[HttpPost]
 public IActionResult Create(student std)
        {
            string message = std.studentID + "-";
            message += std.studentName + "-";
            message += std.studentAge;
            ViewBag.TT = message;
            return View();
        }
        

}
}
