using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OdeToFood.Entity
{
    [DataContract]
    public class RestaurantReview
    {
        [DataMember]
        public int RestaurantReviewId { get; protected set; }

        [DataMember]
        [Required]
        [Range(1,10)]
        public int Rating { get; set; }

        [DataMember]
        [Required]
        [StringLength(1024)]
        public string Body { get; set; }

        [DataMember]
        [Required]
        [StringLength(1024)]
        public string ReviewerName { get; set; }

        [DataMember]
        public int RestaurantId { get; set; }
    }
}