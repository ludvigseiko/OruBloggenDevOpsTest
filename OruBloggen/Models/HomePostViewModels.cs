using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class HomePostViewModel
    {
        public AddPostViewModel AddPostViewModel { get; set; }
        public List<PostViewModel> PostViewModel { get; set; }
        public List<PostReportModel> PostReportModels { get; set; }
    }
}