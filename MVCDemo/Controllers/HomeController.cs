using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemoDataLibrary;


namespace MVCDemo.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
            
        public ActionResult DangKiKhachHang()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangKiKhachHang(KhachHangModel model)
        {

            if (ModelState.IsValid)
            {
                int recordCreated = MVCDemoDataLibrary.BussinessLogic.KhachHangProcessor.CreateKhachHang(model.HoVaTen, model.MaKhachHang);

                return RedirectToAction("DanhSachKhachHang");
            }
            return View();
        }


        public ActionResult DanhSachKhachHang()
        {
            var data = MVCDemoDataLibrary.BussinessLogic.KhachHangProcessor.LoadKhachHang();
            List<KhachHangModel> khachHang = new List<KhachHangModel>();
            foreach (var row in data)
            {
                khachHang.Add(new KhachHangModel { HoVaTen = row.HoVaTen, MaKhachHang = row.MaKhachHang});


            }
            return View(khachHang);

        }
    }
}