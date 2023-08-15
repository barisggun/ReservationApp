﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.Areas.Member.Controllers
{
	[Area("Member")]
	[AllowAnonymous]
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
