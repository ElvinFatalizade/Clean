using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Klinspot.Models;

namespace Klinspot.ViewModels
{
    public class Aboutpage
    {

        public Pageheader  Pageheader { get; set; }

        public AboutText AboutText { get; set; }

        public List<Member> Members { get; set; }

        public List<Client> Clients { get; set; }

        public List<Partner> Partners { get; set; }
    }
}