using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class NotificationModel
    {
        [Key]
        public int NotificationID { get; set; }
        public string UserID { get; set; }
        public string FollowUserID { get; set; }
        public int FollowCategoryID { get; set; }
        public int FollowMeetingID { get; set; }
    }
}