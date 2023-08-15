using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.Areas.Member.Controllers
{
	public class MessageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
