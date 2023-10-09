using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReservationApp.Panel.UI.Models;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }

        public static List<CityClass> cities = new List<CityClass>
        {
            new CityClass
            {
                CityID = 1,
                CityName = "Üsküp",
                CityCountry ="Makedonya"
            },
            new CityClass
            {
                CityID = 2,
                CityName ="Roma",
                CityCountry ="İtalya"
            },
            new CityClass
            {
                CityID = 3,
                CityName = "Istanbul",
                CityCountry = "Turkey"
            }
        };

    }
}
