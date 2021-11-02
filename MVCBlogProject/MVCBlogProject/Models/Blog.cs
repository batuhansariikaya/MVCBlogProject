using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
namespace MVCBlogProject.Models
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogHeading { get; set; }
        [AllowHtml]
        public string BlogDescription { get; set; }
        public DateTime Date { get; set; }
        public string BlogImage { get; set; }
        public string AuthorName { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}