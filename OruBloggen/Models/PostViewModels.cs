using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class PostViewModel
    {
        public int PostID { get; set; }
        public string PostTitle { get; set; }
        public string PostText { get; set; }
        public DateTime PostDate { get; set; }
        public List<PostFilesModel> PostFilePath { get; set; }
        public bool PostFormal { get; set; }
        public string PostSender { get; set; }
        public string PostSenderName { get; set; }
        public string PostCategory { get; set; }
        public string SenderProfilePath { get; set; }
    }

    public class PostReportPageViewModel
    {
        public List<PostReportViewModel> ReportList { get; set; }
    }

    public class PostReportViewModel
    {
        public int PostID { get; set; }
        public string PostTitle { get; set; }
        public string PostText { get; set; }
        public List<PostFilesModel> PostFilePath { get; set; }
        public string PostFormal { get; set; }
        public string PostSenderName { get; set; }
        public int ReportID { get; set; }
        public string ReportReason { get; set; }
    }


}