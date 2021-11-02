using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBlogProject.Models
{
    public class MultipleClass
    {
        public IEnumerable<Blog> value1 { get; set; }
        public IEnumerable<Comment> value2 { get; set; }
        public IEnumerable<Blog> value3 { get; set; }
        public IEnumerable<Author> value4 { get; set; }
        public IEnumerable<Category> value5 { get; set; }
    }
}