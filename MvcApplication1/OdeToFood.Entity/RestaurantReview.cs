using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace OdeToFood.Entity
{
    public class RestaurantReview
    {
        public int RestaurantReviewId { get; protected set; }

        [Required]
        [Range(1,10)]
        public int Rating { get; set; }
        
        [Required]
        [StringLength(1024)]
        public string Body { get; set; }

        [Required]
        [StringLength(1024)]
        public string ReviewerName { get; set; }

        public int RestaurantId { get; set; }
    }
}