using Microsoft.AspNetCore.Mvc;
using NguyenThiKhamBTH.Models.Process;

namespace NguyenThiKhamBTH.Controllers
{
public class StringProcessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
   
        StringProcess Str = new StringProcess ();
       
        [HttpPost]
        // Xoa bo ky tu trang
        public IActionResult Index (string strInput)
        {
            string TB = Str.RemoveRemainingWhiteSpace(strInput);
            ViewBag.Chuoi = TB;
            return View();
        }
        public IActionResult creat()
        {
            return View();
        }

        // Chuyen chuoi sang in hoa
        [HttpPost]
        public IActionResult creat(string strInput)
        {
            string abc = Str.LowerToUpper(strInput);
            ViewBag.Hienthi = abc;
            return View();
        }
        public IActionResult chuthuong()
        {
            return View();
        }
        // Chuyen chuoi sang in thuong
        [HttpPost]
        public IActionResult chuthuong(string strInput)
        {
            string up = Str.UpperToLower(strInput);
            ViewBag.Inthuong = up;
            return View();
        }
        public IActionResult kytudaucactu()
        {
            return View();
        }

        [HttpPost]
        // Viet hoa chu cai dau 
        public IActionResult kytudaucactu(string strInput)
        {
            string capitaone = Str.CapitalizeOneFirstCharacter(strInput);
            ViewBag.ThongBao = capitaone;
            return View();
        }
        public IActionResult kytudauchuoi()
        {
            return View();
        }
        [HttpPost]
        // Viet hoa chu cai dau tien cua cac tu trong chuoi
        public IActionResult kytudauchuoi(string strInput)
        {
            string capitaFirst = Str.CapitalizeFirstCharacter(strInput);
            ViewBag.ThongBao= capitaFirst;
            return View();
        }
        public IActionResult Remove()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Remove(string strInput)
        {
            string remove = Str.RemoveVietnameseAccents(strInput);
            ViewBag.Remo = remove;
            return View();
        }
    }
}

