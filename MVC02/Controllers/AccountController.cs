using Microsoft.AspNetCore.Mvc;
namespace MVC02.Controllers
{
    public class AccountController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Rigester() 
        {
            return View();
        }

        public IActionResult Login() 
        {
            return View();
        }
    }
}
