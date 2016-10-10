using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Review Title")]
        public string Title { get; set; }
        [Display(Name = "Date")]
        public DateTime PublishedDate { get; set; }
        [Display(Name = "Review Body")]
        public string Content { get; set; }
        public string UserName { get; set; }


        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}