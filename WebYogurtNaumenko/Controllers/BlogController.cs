using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Freeeze.Models;

namespace JogurtovejWeb.Controllers
{
    public class BlogController : Controller
    {
        private MyContext context = new MyContext();
        // GET: Blog
        public ActionResult Index()
        {
            return View(context.blogs.ToList());
        }
        public ActionResult Blog()
        {
            ViewBag.Message = "Your contact page.";

            return View(context.blogs.OrderByDescending(x => x.Date).ToList());
        }
        public ActionResult Product()
        {
            ViewBag.Message = "Your contact page.";


            return View(context.kategories.Include("tbProducts").ToList());
        }
        public ActionResult SinglePost(int id)
        {
            var blog = context.blogs.SingleOrDefault(x => x.idBlog == id);
            return View(blog);
        }
        public ActionResult MoreProducts(int id)
        {
            var products = context.kategories.Include("tbProducts").SingleOrDefault(x => x.idKategorie == id);
            return View(products);
        }
    }
}