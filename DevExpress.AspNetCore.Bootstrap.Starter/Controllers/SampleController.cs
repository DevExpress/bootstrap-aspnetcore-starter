using Microsoft.AspNetCore.Mvc;
using System;

namespace DevExpress.AspNetCore.Bootstrap.Starter {
    public class SampleController : Controller {
        NorthwindContext context;
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
            return View(context.Invoices);
        }
        public IActionResult GridViewPartial() {
            return PartialView(context.Invoices);
        }
        public IActionResult UpdateRow(Invoice invoice) {
            try {
                if(ModelState.IsValid) {
                    context.Invoices.Update(invoice);
                    context.SaveChanges();
                }
            }
            catch(Exception e) {
                ViewData["error"] = e.Message;
            }
            return PartialView("GridViewPartial", context.Invoices);
        }
        public IActionResult AddNewRow(Invoice invoice) {
            try {
                if(ModelState.IsValid) {
                    context.Invoices.Add(invoice);
                    context.SaveChanges();
                }
            }
            catch(Exception e) {
                ViewData["error"] = e.Message;
            }
            return PartialView("GridViewPartial", context.Invoices);
        }
        public IActionResult DeleteRow(long id) {
            try {
                if(ModelState.IsValid) {
                    Invoice invoice = context.Invoices.Find(id);
                    if(invoice != null) {
                        context.Invoices.Remove(invoice);
                    }
                    context.SaveChanges();
                }
            }
            catch(Exception e) {
                ViewData["error"] = e.Message;
            }
            return PartialView("GridViewPartial", context.Invoices);
        }
        public SampleController(NorthwindContext context) {
            this.context = context;
        }
    }
}