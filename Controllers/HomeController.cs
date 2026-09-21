using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult BaiTap01_Lab01a()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BaiTap02_Lab01a()
        {
            ViewBag.Message = " Hãy xây dựng trang web hiển thị các công thức";

            return View();
        }
        public ActionResult BaiTap03_Lab01a()
        {
            ViewBag.Message = "Tạo bảng table trên web";

            return View();
        }
        public ActionResult BaiTap01_Lab01b()
        {
            ViewBag.Message = "Xây dựng cấu trúc thư mục";

            return View();
        }
        public ActionResult BaiTap02_Lab01b()
        {
            ViewBag.Message = "Gộp các ô 2-3-4";

            return View();
        }
        public ActionResult BaiTap03_Lab01b()
        {
            ViewBag.Message = "Thông Tin Sinh Viên ";

            return View();
        }
        public ActionResult BaiTap04_Lab01b()
        {
            ViewBag.Message = "Thông Tin Sinh Viên ";

            return View();
        }

        public ActionResult Bai02_Lab01b2()
        {
            ViewBag.Message = "Sử dụng Table để thiết kế các trang web ";

            return View();
        }
        public ActionResult Bai01_Lab01b2()
        {
            ViewBag.Message = "Dựa vào 2 ví dụ, dùng table để tạo trang có cấu trúc như các hình sau: ";

            return View();
        }
        public ActionResult Bai03_Lab01b2()
        {
            ViewBag.Message = "Sử dụng thẻ Div để thiết kế các trang web  ";

            return View();
        }
        public ActionResult Bai04_Lab01b2()
        {
            ViewBag.Message = "Sử dụng HTML5 để thiết kế các trang web ";

            return View();
        }
        public ActionResult Bai01_Lab01c()
        {
            ViewBag.Message = "Tạo ra cấu trúc thư mục ";

            return View();
        }
        public ActionResult Bai02_Lab01c()
        {
            ViewBag.Message = " Trong trang login.html sử dụng thẻ <form> <input> để tạo chức năng đăng nhập như sau.";

            return View();
        }
        public ActionResult Bai03_Lab01c()
        {
            ViewBag.Message = " Xây dựng trang repass.html lấy lại mật khẩu như sau kết hợp <fieldset> ";

            return View();

        }

        public ActionResult Bai04_Lab01c()
        {
            ViewBag.Message = "  Xây dựng trang đăng ký regist.html ";

            return View();

        }
        public ActionResult BaiNangCao_Lab01c()
        {
            ViewBag.Message = "Bổ sung <table> vào bài tập 4 để có được giao diện như sau ";

            return View();

        }

    }
}

       
    
