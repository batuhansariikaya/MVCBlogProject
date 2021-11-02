using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCBlogProject.Models
{
    public class Adress
    {
        [Key]
        public int AdressID { get; set; }
        public string AdressHeading { get; set; }
        public string AdressDescription { get; set; }
        public string Adres { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Place { get; set; }

    }
}