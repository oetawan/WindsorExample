using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace OdeToFood.Entity
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }

        [Required]
        [StringLength(1024)]
        public string Name { get; set; }

        [Required]
        [StringLength(1024)]
        public string City { get; set; }

        [Required]
        [StringLength(1024)]
        public string Country { get; set; }

        public virtual ICollection<RestaurantReview> Reviews { get; set; }
    }
}