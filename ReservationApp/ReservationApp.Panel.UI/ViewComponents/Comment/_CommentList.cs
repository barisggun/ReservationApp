using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());

        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.TGetDestinationCommentById(id);
            return View(values);
        }
    }
}
