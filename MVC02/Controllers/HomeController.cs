using Microsoft.AspNetCore.Mvc;
using System;

namespace MVC02.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }

        public IActionResult AboutUs() 
        {
            return View();
        }

        public IActionResult Index02(int id, Employee emp)
        {
            return Content($"Hello number {id} From Complex index");
        }


        public ContentResult Test02() 
        {

            /*
             * Content result is a class That Implement from IActionResult Interface (Father)
             * 
             */

            //Instead of creating object each time we use the Class we can use Helper Method
            //ContentResult result = new ContentResult();
            //result.Content = "Iam Test02";


            return Content("Iam Test02"); // Helper Method
        }


        public RedirectToActionResult GoTo() 
        {
            //RedirectToActionResult result = new RedirectToActionResult("Test02","Home",new { });
            return RedirectToAction("Test02");
        }



    }
}
