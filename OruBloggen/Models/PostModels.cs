using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class PostModel
    {
        [Key]
        public int PostID { get; set; }
        public string PostTitle { get; set; }
        public string PostText { get; set; }
        public DateTime PostDate { get; set; }
        public bool PostFormal { get; set; }

        [ForeignKey("PostUserID")]
        public virtual UserModel UserModel { get; set; } 
        public string PostUserID { get; set; }

        [ForeignKey("PostCategoryID")]
        public virtual CategoryModel CategoryModel { get; set; }
        public int PostCategoryID { get; set; }

        [InverseProperty("PostModel")]
        public virtual List <PostReportModel> PostReportModels { get; set; }

        [InverseProperty("PostModel")]
        public virtual List<PostFilesModel> PostFiles { get; set; }
    }
}