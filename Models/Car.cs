using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        [Required]
        public string CarName { get; set; }
        [Required]
        public int Power { get; set; }
        [Required]
        public int Torque { get; set; }
        [Required]
        public int Weight { get; set; }
        public string CarPicture { get; set; }
        [ForeignKey("BrandID")]
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
    }
}