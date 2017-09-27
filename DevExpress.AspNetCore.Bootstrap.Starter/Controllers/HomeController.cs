using Microsoft.AspNetCore.Mvc;
using System;

namespace DevExpress.AspNetCore.Bootstrap.Starter {
    public class HomeController : Controller {
        public HomeController() { }
        public IActionResult Index() {
            return View();
        }
        public IActionResult Error() {
            return View();
        }
    }
}
