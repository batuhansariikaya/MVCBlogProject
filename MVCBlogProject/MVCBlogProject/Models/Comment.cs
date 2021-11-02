using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCBlogProject.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommentMail { get; set; }
        public string Comments { get; set; }
        public bool CommentStatus { get; set; }
        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }
    }
}