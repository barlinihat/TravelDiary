using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelDiary.Models.Classes;

namespace TravelDiary.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();
        BlogComment bc = new BlogComment();

        public ActionResult Blog()
        {
            //var blogs = context.Blogs.ToList();
            bc.ValueOne = context.Blogs.ToList();
            bc.ValueThree = context.Blogs.Take(3).ToList();
            return View(bc);
        }
        public ActionResult BlogDetail(int id)
        {
            //var blogFind = context.Blogs.Where(x => x.ID == id).ToList();
            bc.ValueOne = context.Blogs.Where(x => x.ID == id).ToList();
            bc.ValueTwo = context.Comments.Where(x => x.ID == id).ToList();
            return View(bc);
        }
    }
}