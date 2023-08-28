using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            return View(values);
        }
    }
}
