using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DangNhap.BLL;
using DangNhap.Models;

namespace DangNhap.Controllers
{
    public class HomeController : Controller
    {
        private TaiKhoanBLL _taiKhoanBll = new TaiKhoanBLL();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
       
        public ActionResult Index(string username, string password)
        {
            bool check = _taiKhoanBll.DangNhap(username, password);
            if (check)
            {
                return RedirectToAction("Contact");
            }
            else
            {
                ViewBag.Noti = "Tên đăng nhập hoặc mật khẩu không chính xác";
                return View();
            }
        }

        public ActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangKy(TaiKhoan taiKhoan)
        {
            if (ModelState.IsValid)
            {
               bool check =  _taiKhoanBll.DangKy(taiKhoan);
               if (check)
               {
                   return RedirectToAction("Index");
               }
               else
               {
                   ViewBag.Noti = "Tài khoản đã tồn tại";
               }
            }
            return View(taiKhoan);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}