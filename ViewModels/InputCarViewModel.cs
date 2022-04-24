using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class InputCarViewModel
    {
        [Required]
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
        [Required]
        public int BrandId { get; set; }
    }
}