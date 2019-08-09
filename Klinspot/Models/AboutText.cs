using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Klinspot.Models
{
    public class AboutText
    {
        public int Id { get; set; }

        [MaxLength(300)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [Column(TypeName ="ntext")]
        [MaxLength(1000)]
        public string Text { get; set; }
    }
}