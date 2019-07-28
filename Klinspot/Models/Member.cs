using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Klinspot.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Fullname { get; set; }

        [Required, MaxLength(100)]
        public string Position { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }


        public List <MembersLink>MembersLinks { get; set; }


    }
}