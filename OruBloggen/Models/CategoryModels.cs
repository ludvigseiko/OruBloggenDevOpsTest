using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool IsFormel { get; set; }

        [InverseProperty("CategoryModel")]
        public virtual List<PostModel> PostModel { get; set; }
    }
}