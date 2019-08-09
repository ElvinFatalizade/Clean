using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klinspot.ViewModels
{
    public class Pageheader
    {
        public string Name { get; set; }

        public string BackgroundPhoto { get; set; }

        public Dictionary<string,string> Breadcrump { get; set; }
    }
}