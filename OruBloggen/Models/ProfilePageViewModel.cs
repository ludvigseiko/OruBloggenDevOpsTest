using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class ProfilePageViewModel
    {
        public string userId { get; set; }
        public string OtherUserID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Team { get; set; }
        public int PhoneNumber { get; set; }
        public string Position { get; set; }
        public string ImagePath { get; set; }
        public string UserIsFollowed { get; set; }
        public string FollowedID { get; set; }
        public List<NotificationModel> IsFollowed { get; set; }

        public bool UserSmsNotification { get; set; }
        public bool UserPmNotification { get; set; }
        public bool UserEmailNotification { get; set; }

        public List<MeetingModel> MeetingModels { get; set; }
        public List<UserMeetingModel> UserMeetings { get; set; }
        public List<UserModel> Users { get; set; }

        public List<CategoryModel> ListCategories { get; set; }
    }
}