using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCBlogProject.Models
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string ContactMessage { get; set; }
        public string ContactSubject { get; set; }
        public string ContactMail { get; set; }
    }
}