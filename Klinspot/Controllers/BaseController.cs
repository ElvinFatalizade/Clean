using Klinspot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Klinspot.Controllers
{
    public class BaseController : Controller
    {
        protected readonly KlinspotContext _context;

       public BaseController()
        {
            _context = new KlinspotContext();

            ViewBag.SocialLink = _context.SocialLinks.OrderBy(sl => sl.OderBy).ToList();
            ViewBag.Setting = _context.Settings.FirstOrDefault();
        }
    }
}