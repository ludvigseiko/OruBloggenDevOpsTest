using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class AddPostViewModel
    {
        public string PostTitle { get; set; }

        public string PostText { get; set; }

        public string File { get; set; }

        public bool PostFormal { get; set; }
        public string PostCategory { get; set; }      
    }
}