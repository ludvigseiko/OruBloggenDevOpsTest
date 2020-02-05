using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class UserModel
    {
        [Key]
        public string UserID { get; set; }
        public string UserFirstname { get; set; }
        public string UserLastname { get; set; }
        public DateTime UserBirthDate { get; set; }
        public int UserPhoneNumber { get; set; }
        public string UserPosition { get; set; }

        public bool UserSmsNotification { get; set; }
        public bool UserPmNotification { get; set; }
        public bool UserEmailNotification { get; set; }

        public bool UserActive { get; set; }

        [DataType(DataType.ImageUrl)]
        public string UserImagePath { get; set; }

        public bool UserIsAdmin { get; set; }
        [ForeignKey("UserTeamID")]
        public virtual TeamModel TeamModel { get; set; }
        public int UserTeamID { get; set; }

        [InverseProperty("UserModelSender")]
        public virtual List<MessageModel> MessageModelSender { get; set; }
        [InverseProperty("UserModelReceiver")]
        public virtual List<MessageModel> MessageModelReceiver { get; set; }
        [InverseProperty("UserModel")]
        public virtual List<UserMeetingModel> UserMeetingModel { get; set; }
        [InverseProperty("UserModel")]
        public virtual List<ProjectModel> ProjectModel { get; set; }
        [InverseProperty("UserModel")]
        public virtual List<MeetingModel> MeetingModel { get; set; }
        [InverseProperty("UserModel")]
        public virtual List<PostModel> PostModel { get; set; }
        [InverseProperty("UserModel")]
        public virtual List<ProjectCommentModel> ProjectComments { get; set; }

        public UserModel()
        {
            UserIsAdmin = false;
            UserActive = false;
            UserSmsNotification = true;
            UserPmNotification = true;
            UserEmailNotification = true;
        }
    }
}