using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ReservationApp.Panel.UI.ViewComponents.MemberDashboard
{
    public class _GuideList:ViewComponent
    {
        GuideManager gm = new GuideManager(new EfGuideDal());
        public IViewComponentResult Invoke()
        {
            var values = gm.TGetList();
            return View(values);
        }
    }
}
