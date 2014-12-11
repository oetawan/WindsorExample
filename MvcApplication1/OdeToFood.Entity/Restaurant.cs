using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Entity
{
    [DataContract]
    public class Restaurant
    {
        [DataMember]
        public int RestaurantId { get; set; }

        [DataMember]
        [Required]
        [StringLength(1024)]
        public string Name { get; set; }

        [DataMember]
        [Required]
        [StringLength(1024)]
        public string City { get; set; }

        [DataMember]
        [Required]
        [StringLength(1024)]
        public string Country { get; set; }

        [DataMember]
        public virtual ICollection<RestaurantReview> Reviews { get; set; }
    }
}