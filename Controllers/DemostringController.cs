using Microsoft.AspNetCore.Mvc;
using NguyenThiKhamBTH.Models.Process;

namespace NguyenThiKhamBTH.Controllers
{
public class StringProcessController : Controller
    {
        StringProcess strPro = new StringProcess();
[HttpPost]
        public IActionResult Index( string str)
        {
            string result = strPro.Remo (str);
            ViewBag.Chuoi = result;
            return View();
        }
        [HttpPost]
         public IActionResult chuhoa (string strInput)
         {
             string ketqua = strPro.Lower(strInput);
            ViewBag.thongbao = ketqua;
             return View();
         }
         [HttpPost]
         public IActionResult chuthuong (string strInput)
         {
             string ketqua = strPro.Upper(strInput);
            ViewBag.TB = ketqua;
             return View();
         }
         [HttpPost]
         public IActionResult kytudauchuoi (string strInput)
         {
             string ketqua = strPro.Capital(strInput);
            ViewBag.TT = ketqua;
             return View();
         }
         [HttpPost]
         public IActionResult kytudaucactu (string strInput)
         {
             string ketqua = strPro.Capital(strInput);
            ViewBag.ThongBao = ketqua;
             return View();
         }
    }
    }

