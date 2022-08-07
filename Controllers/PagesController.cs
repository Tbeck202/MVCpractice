using Microsoft.AspNetCore.Mvc;
using MVCpractice2.Models;


namespace MVCpractice2.Controllers
{
    public class PagesController : Controller
    {
        private static List<VisitorViewModel> visitors = new List<VisitorViewModel>();
        public IActionResult PageOne()
        {
            return View(visitors);
        }
        public IActionResult PageTwo()
        {
            return View();
        }

        public IActionResult PageThree()
        {
            VisitorViewModel visitorVm = new VisitorViewModel();

            return View(visitorVm);
        }
        public IActionResult CreateVisitor(VisitorViewModel visitor)
        {
            visitors.Add(visitor);
            return RedirectToAction("PageOne");
        }
    }
}
