using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.ViewComponents.AdminDashboard
{
    public class _AdminDashboardHeader:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

