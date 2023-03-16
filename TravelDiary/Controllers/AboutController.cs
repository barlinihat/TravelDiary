using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelDiary.Models.Classes;

namespace TravelDiary.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        Context context = new Context();
        public ActionResult About()
        {
            var contents = context.Abouts.ToList();
            return View(contents);
        }
    }
}