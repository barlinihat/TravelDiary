using System;
using System.Linq;
using System.Web.Mvc;
using TravelDiary.Models.Classes;


namespace TravelDiary.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialOne()
        {
            var value = context.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialTwo()
        {
            var value = context.Blogs.Where(x => x.ID==1).ToList();
            return PartialView(value);
        }
    }
}