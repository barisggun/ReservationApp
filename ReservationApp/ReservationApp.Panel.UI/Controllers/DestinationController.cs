﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

        public IActionResult DestinationDetails(int id)
        {
            var values = destinationManager.TGetById(id);   
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }
    }
}