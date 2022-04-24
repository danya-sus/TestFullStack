using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class InputBrandViewModel
    {
        [Required]
        public string BrandName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string BrandPicture { get; set; }
    }
}