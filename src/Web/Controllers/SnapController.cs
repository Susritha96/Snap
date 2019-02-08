using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class SnapController : Controller
    {
        public IActionResult Snap()
        {
            return View();
        }
        public IActionResult GoodSnap()
        {
            return Content("This is a very good snap .");
        }
        public IActionResult ShowJSON()
        {
            return Json(new { name = "favorite quote", quote = "This is my favorite Snap." });
        }
        public IActionResult ShowHTML()
        {
            var h = "<!DOCTYPE html><html><head><header>Welcome</header></head><body>There are two types of snap <li>potriat</li><li>landscape</li> Note return path has to use the name of the controller." +
            "<br><br></body></html>";
            return Content(h, "text/html");
        }

    }
}
