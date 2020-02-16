using Blog.Domain.Concrete;
using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.WebUI.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork unit;

        public HomeController()
        {
            unit = new UnitOfWork();
        }

        public ActionResult Index()
        {
            List<Article> articles = unit.Articles.FindAll().ToList();

            return View(articles);
        }

       
    }
}