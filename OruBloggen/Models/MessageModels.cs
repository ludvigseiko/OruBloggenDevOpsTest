using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class MessageModel
    {
        [Key]
        public int MessageID { get; set; }
        [ForeignKey("MessageSenderID")]
        public virtual UserModel UserModelSender { get; set; }
        public string MessageSenderID { get; set; }
        [ForeignKey("MessageReceiverID")]
        public virtual UserModel UserModelReceiver { get; set; }
        public string MessageReceiverID { get; set; }
        public string MessageTitle { get; set; }
        public string MessageText { get; set; }
        public bool MessageRead { get; set; }

        public MessageModel()
        {
            MessageRead = false;
        }
    }

   
}