using Microsoft.AspNetCore.Mvc;
using NguyenThiKhamBTH.Models.Process;

namespace NguyenThiKhamBTH.Controllers
{
    public class DemoController : Controller
    {
        // tạo các action thực thi các nhiệm vụ
        public IActionResult Index()
        {
            return View();
        }
        Giaiphuongtrinh gpt = new Giaiphuongtrinh();
        [HttpPost]
        public IActionResult Index(string hesoA, string hesoB )
        {
            double a = Convert.ToDouble(hesoA);
            double b = Convert.ToDouble(hesoB);
            string thongbao = gpt.Giaiphuongtrinhbacnhat(a,b);
            ViewBag.mess = thongbao;
            return View();
        }
        
    
    
    // phương trình bậc 2
        public IActionResult Create(string heSoA,string heSoB, String heSoC)
        {
            double A = Convert.ToDouble(heSoA);
            double B = Convert.ToDouble(heSoB);
            double C = Convert.ToDouble(heSoC);
            string thongBao = gpt.Giaiphuongtrinhbachai(A, B, C);
            ViewBag.abc = thongBao;
            return View();
        }
    }
}
       
       
    
