using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Brand
    {
        public Brand()
        {
            this.Car = new HashSet<Car>();
        }

        [Key]
        public int BrandId { get; set; }
        [Required]
        public string BrandName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string BrandPicture { get; set; }
        public virtual ICollection<Car> Car { get; set; }
    }
}