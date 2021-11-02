using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCBlogProject.Models
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string ImageURL { get; set; }
        public string AboutDescription { get; set; }
        public bool AboutStatus { get; set; }
    }
}