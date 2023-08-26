using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.ViewComponents.AdminDashboard
{
    public class _DashboardBanner : ViewComponent   
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
