using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Rating")]
        public string Name { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}