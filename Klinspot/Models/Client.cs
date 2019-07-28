using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Klinspot.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Fullname { get; set; }

        [Required, MaxLength(100)]
        public string Company { get; set; }

        [MaxLength(100)]
        public string Text { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

    }
}