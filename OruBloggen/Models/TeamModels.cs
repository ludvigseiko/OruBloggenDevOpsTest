using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class TeamModel
    {
        [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }

        [InverseProperty("TeamModel")]
        public virtual List<ProjectModel> ProjectModels { get; set; }
        [InverseProperty("TeamModel")]
        public virtual List<UserModel> UserModels { get; set; }
    }
}