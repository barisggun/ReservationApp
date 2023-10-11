using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
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

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }

        public IActionResult GetById(int DestinationID)
        {
            var values = _destinationService.TGetById(DestinationID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        [HttpPost]
        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetById(id);
            _destinationService.TDelete(values);
            return NoContent();
        }


        public IActionResult UpdateCity(Destination destination)
        {
            var existingDestination = _destinationService.TGetById(destination.DestinationID);

            if (existingDestination != null)
            {
                // Sadece güncellenen alanları güncelleyin
                existingDestination.City = destination.City;
                existingDestination.DayNight = destination.DayNight;

                // Değişiklikleri kaydedin
                _destinationService.TUpdate(existingDestination);

                return Json("Güncelleme işlemi yapıldı");
            }
            else
            {
                return Json("Belirtilen destinasyon bulunamadı");
            }
        }


        //public static List<CityClass> cities = new List<CityClass>
        //{
        //    new CityClass
        //    {
        //        CityID = 1,
        //        CityName = "Üsküp",
        //        CityCountry ="Makedonya"
        //    },
        //    new CityClass
        //    {
        //        CityID = 2,
        //        CityName ="Roma",
        //        CityCountry ="İtalya"
        //    },
        //    new CityClass
        //    {
        //        CityID = 3,
        //        CityName = "Istanbul",
        //        CityCountry = "Turkey"
        //    }
        //};

    }
}
