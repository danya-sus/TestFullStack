using AutoMapper;
using System;
using WebApplication1.Models;

namespace WebApplication1.ViewModels.AytoMapperProfiles
{
    public class BrandViewModelProfile : Profile
    {
        public BrandViewModelProfile()
        {
            CreateMap<Brand, BrandViewModel>();
        }
    }
}