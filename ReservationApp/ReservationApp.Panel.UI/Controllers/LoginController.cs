using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

        public IActionResult SignUp()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult SignUp()
        //{
        //    return View();
        //}

        public IActionResult SignIn()
        {
            return View();
        }
    }
}
