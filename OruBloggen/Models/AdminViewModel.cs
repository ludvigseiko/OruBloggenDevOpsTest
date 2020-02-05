using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OruBloggen.Models
{
    public class AdminViewModel
    {
        public List<PostViewModel> PostList { get; set; }
        public List<SelectListItem> Teams { get; set; }

        public PostReportModel postReportModel { get; set; }

        public UserModel MyAccount { get; set; }
        public List<UserAdminViewModel> Userlist { get; set; }
    }

    public class UserAdminViewModel
    {
        public string UserID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Socialnumber { get; set; }
        public int Phonenumber { get; set; }
        public string ImagePath { get; set; }
        public bool isAdmin { get; set; }
        public int TeamID { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
    }

    public class NewsViewModel
    {
        public NewsModel News { get; set; }
        public List<NewsModel> NewsList { get; set; }
    }
}