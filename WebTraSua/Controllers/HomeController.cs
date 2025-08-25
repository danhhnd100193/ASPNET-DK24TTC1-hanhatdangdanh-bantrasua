using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTraSua.Controllers
{
    public class HomeController : Controller
    {
  
           public ActionResult Index()
        {
            // Danh sách ảnh, có thể lấy từ DB
            var banners = new List<string>
    {
        Url.Content("~/images/banner1.jpg"),
        Url.Content("~/images/banner2.jpg"),
        Url.Content("~/images/banner3.jpg")
    };

            ViewBag.Banners = banners;
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
    }
}