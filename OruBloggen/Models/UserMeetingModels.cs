using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class UserMeetingModel
    {
        [Key]
        public int UserMeetingID { get; set; }
        [ForeignKey("MeetingID")]
        public virtual MeetingModel MeetingModel { get; set; }
        public int MeetingID { get; set; }
        [ForeignKey("UserID")]
        public virtual UserModel UserModel { get; set; }
        public string UserID { get; set; }
        public bool AcceptedInvite { get; set; }

        public UserMeetingModel()
        {
            AcceptedInvite = false;
        }
    }
}