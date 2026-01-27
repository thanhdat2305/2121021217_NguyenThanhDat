using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Baithuchanhso3.Models;

namespace Baithuchanhso3.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello Nguyễn Thành Đạt - MSV: 2121051217";
            return View();
        }
    }
}