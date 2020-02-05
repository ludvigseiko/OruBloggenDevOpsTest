using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class ProjectFilesModel
    {
        [Key]
        public int ProjectFileID { get; set; }

        [ForeignKey("ProjectID")]
        public virtual ProjectModel ProjectModel { get; set; }
        public int ProjectID { get; set; }

        public string FilePath { get; set; }
    }
}