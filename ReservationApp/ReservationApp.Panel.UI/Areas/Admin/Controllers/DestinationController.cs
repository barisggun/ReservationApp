﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager dm = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = dm.TGetList();
            return View(values);
        }

        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            dm.TAdd(destination);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }

        public IActionResult DeleteDestination(int id)
        {
            var values = dm.TGetById(id);
            dm.TDelete(values);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }
        public IActionResult UpdateDestination(int id) 
        {
            var values = dm.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            dm.TUpdate(destination);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }
    }
}
