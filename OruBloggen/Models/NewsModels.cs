using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class NewsModel
    {
        [Key]
        public int NewsID { get; set; }
        public string NewsTitle { get; set; }
        public string NewsText { get; set; }
        public DateTime NewsDate { get; set; }
    }
}