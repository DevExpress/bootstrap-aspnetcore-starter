using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DevExpress.AspNetCore.Bootstrap.Starter {
    public class SampleController : Controller {

        public SampleController(NorthwindContext context) {
            NorthwindContext = context;
        }

        protected NorthwindContext NorthwindContext { get; }


        public IActionResult RegisterForm() {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterForm(Person person) {
            if(ModelState.IsValid)
                ViewData["Message"] = "Thank you for registering!";
            return View(person);
        }

        public IActionResult GridView() {
            return View(NorthwindContext.Products);
        }
        public IActionResult GridViewPartial() {
            return PartialView(NorthwindContext.Products);
        }
        public IActionResult AddNewRow(Product product) {
            try {
                if(ModelState.IsValid) {
                    product.ProductID = NorthwindContext.Products.Max(p => p.ProductID) + 1;
                    NorthwindContext.Products.Add(product);
                    NorthwindContext.SaveChanges();
                }
            } catch(Exception e) {
                ViewData["error"] = e.Message;
            }
            return PartialView("GridViewPartial", NorthwindContext.Products);
        }
        public IActionResult UpdateRow(Product product) {
            try {
                if(ModelState.IsValid) {
                    NorthwindContext.Products.Update(product);
                    NorthwindContext.SaveChanges();
                }
            } catch(Exception e) {
                ViewData["error"] = e.Message;
            }
            return PartialView("GridViewPartial", NorthwindContext.Products);
        }
        public IActionResult DeleteRow(int productID = -1) {
            var product = NorthwindContext.Products
                .FirstOrDefault(i => i.ProductID == productID);
            try {
                NorthwindContext.Products.Remove(product);
                NorthwindContext.SaveChanges();
            } catch(Exception e) {
                ViewData["error"] = e.Message;
            }
            return PartialView("GridViewPartial", NorthwindContext.Products);
        }
    }
}