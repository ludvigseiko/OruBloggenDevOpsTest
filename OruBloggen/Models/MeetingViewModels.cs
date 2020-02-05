using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OruBloggen.Models
{
    public class MeetingViewModel
    {
        public MeetingModel Meeting { get; set; }
        public IEnumerable<SelectListItem> Users { get; set; }
        public IEnumerable<string> UserIds { get; set; }
        public IEnumerable<SelectListItem> SelectedUsers { get; set; }
        public IEnumerable<string> SelectedUserIds { get; set; }

    }

    public class CalenderViewModel
    {
        public int MeetingID { get; set; }
        public string MeetingTitle { get; set; }
        public string MeetingDesc { get; set; }
        public string MeetingCreator { get; set; }
        public DateTime MeetingStartDate { get; set; }
        public DateTime MeetingEndDate { get; set; }
        public bool MeetingActive { get; set; }
        public string TeamName { get; set; }
    }

    public class UserMeetingViewModel
    {
        public virtual UserModel UserModel { get; set; }
        public string UserID { get; set; }
    }

    public class MeetingUserViewModel
    {
        public List<MeetingModel> Meetings { get; set; }
        public List<UserModel> Users { get; set; }
        public List<UserMeetingModel> UserMeetings { get; set; }
    }

}