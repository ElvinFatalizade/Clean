using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Klinspot.Models;
using Klinspot.ViewModels;

namespace Klinspot.Controllers
{
    public class AboutController : BaseController
    {
        // GET: About
        public ActionResult Index()
        {
            Aboutpage model = new Aboutpage
            {
                AboutText = _context.AboutTexts.FirstOrDefault(),
                Members = _context.Members.Include("MembersLinks").OrderByDescending(o => o.Id).ToList(),
                Clients = _context.Clients.OrderByDescending(c => c.Id).ToList(),
                Partners = _context.Partners.ToList(),
            };

            model.Pageheader = new Pageheader
            {
                Name = "About Us",
                BackgroundPhoto = "header.jpg",
                Breadcrump = new Dictionary<string, string>
                {
                    {"Home", Url.Action("index","home") },
                    {"About Us",null }
                }


            };

            return View(model);
        }
    }
}