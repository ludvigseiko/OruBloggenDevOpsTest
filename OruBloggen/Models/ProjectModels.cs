using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class ProjectModel
    {
        [Key]
        public int ProjectID { get; set; }
        public string ProjectType { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }
        public string ProjectStatus { get; set; }

        [ForeignKey("ProjectTeamID")]
        public virtual TeamModel TeamModel { get; set; }
        public int ProjectTeamID { get; set; }

        [ForeignKey("ProjectUserID")]
        public virtual UserModel UserModel { get; set; }
        public string ProjectUserID { get; set; }

        [InverseProperty("ProjectModel")]
        public virtual List<ProjectFilesModel> ProjectFiles { get; set; }

        [InverseProperty("ProjectModel")]
        public virtual List<ProjectCommentModel> ProjectComments { get; set; }

    }

    public class ProjectCommentModel
    {
        [Key]
        public int CommentID { get; set; }
        public string Comment { get; set; }

        [ForeignKey("ProjectID")]
        public virtual ProjectModel ProjectModel { get; set; }
        public int ProjectID { get; set; }

        [ForeignKey("UserCommentID")]
        public virtual UserModel UserModel { get; set; }
        public string UserCommentID { get; set; }

        public string UserCommentName { get; set; }
        public DateTime CommentDate { get; set; }
    }



    public class ProjectViewModel
    {

        public ProjectModel NewProject { get; set; }
        public List<ProjectItemViewModel> ProjectList { get; set; }
    }

    public class ProjectItemViewModel
    {
        public int ProjectID { get; set; }
        public string ProjectType { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }
        public string ProjectStatus { get; set; }
        public string TeamName { get; set; }
        public string ProjectCreatorName { get; set; }
        public string ProjectCreatorID { get; set; }
        public List<ProjectFilesModel> ProjectFiles { get; set; }
        public List<ProjectCommentModel> ProjectComments { get; set; }
    }
}