using AutoMapper;
using System;
using WebApplication1.Models;

namespace WebApplication1.ViewModels.AytoMapperProfiles
{
    public class CarViewModelProfile : Profile
    {
        public CarViewModelProfile()
        {
            CreateMap<Car, CarViewModel>();
        }
    }
}