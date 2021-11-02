using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCBlogProject.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}