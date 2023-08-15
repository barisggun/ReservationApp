using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.Areas.Member.Controllers
{
	public class ProfileController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
