using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCBlogProject.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
     //   [Required(ErrorMessage ="Lütfen Seçim Yapınız.")]
        public bool CategoryStatus { get; set; }
        public ICollection<Blog> Blogs { get; set; }

    }
}