using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Klinspot.Models
{
    public class Partner
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }

        [MaxLength(200)]
        public string Url { get; set; }
    }
}