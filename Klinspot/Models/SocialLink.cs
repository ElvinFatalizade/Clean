using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Klinspot.Models
{
    public class SocialLink
    {
        public int Id { get; set; }

        [Required]
        public int OderBy { get; set; }

        [MaxLength(50)]
        public string Icon { get; set; }

        [MaxLength(100)]
        public string Url { get; set; }
    }
}