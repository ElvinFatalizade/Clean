using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Klinspot.Models
{
    public class Slide
    {
        public int Id{ get; set; }

        [Required,MaxLength(100)]
        public string Title { get; set; }

        [Required, MaxLength(400)]
        public string Desc { get; set; }

        [MaxLength(50)]
        public string BtnText { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }

        [MaxLength(100)]
        public string BtnUrl { get; set; }
    }
}