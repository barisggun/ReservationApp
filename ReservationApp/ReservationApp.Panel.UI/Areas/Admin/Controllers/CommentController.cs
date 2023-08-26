using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentDal());

        public IActionResult Index()
        {
            var values = cm.TGetList();
            return View(values);
        }
    }
}
