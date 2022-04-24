using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AutomobilesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AutomobilesContext>>()))
            {               
                if (context.Brand.Any())
                {
                    return;
                }

                context.Brand.AddRange(
                    new Brand
                    {
                        BrandName = "Toyota",
                        Description = "The largest Japanese automotive corporation.",
                        BrandPicture = "https://aishaspb.ru/uploads/s/c/a/q/caqumwemrsxf/img/full_gH82k3y6.jpg"
                    },

                    new Brand
                    {
                        BrandName = "Nissan",
                        Description = "Japanese automaker, one of the largest in the world.",
                        BrandPicture = "https://widewp.ru/images/cars/3582.jpg"
                    },

                    new Brand
                    {
                        BrandName = "Mazda",
                        Description = "Japanese automobile manufacturing company that produces Mazda cars.",
                        BrandPicture = "https://i.pinimg.com/originals/f6/58/3b/f6583b3f36e43947c640272fa00617e5.jpg"
                    },

                    new Brand
                    {
                        BrandName = "Mitsubishi",
                        Description = "Japanese conglomerate, one of the first zaibatsu.",
                        BrandPicture = "https://auto.vercity.ru/gallery/img/automobiles/Mitsubishi/2008%20Mitsubishi%20Lancer%20Evolution%20X%20MR/900x/2008%20Mitsubishi%20Lancer%20Evolution%20X%20MR%20001.jpg"
                    }
                );

                if (context.Car.Any())
                {
                    return;
                }

                context.Car.AddRange(
                    new Car
                    {
                        CarName = "Supra",
                        Power = 225,
                        Torque = 284,
                        Weight = 1410,
                        CarPicture = "https://www.jm-imports.co.uk/wp-content/uploads/2017/06/IMG_2976-Copy.jpg",
                        BrandId = 2
                    },
                    new Car
                    {
                        CarName = "Land Cruiser",
                        Power = 309,
                        Torque = 439,
                        Weight = 3350,
                        CarPicture = "https://fix-my-car.ru/wp-content/uploads/2018/06/1920x.jpg",
                        BrandId = 2
                    },
                    new Car
                    {
                        CarName = "RAV4",
                        Power = 149,
                        Torque = 206,
                        Weight = 1570,
                        CarPicture = "https://s1.cdn.autoevolution.com/images/gallery/TOYOTA-RAV4-5-Doors-5920_33.jpg",
                        BrandId = 2
                    },
                    new Car
                    {
                        CarName = "Chaser",
                        Power = 280,
                        Torque = 377,
                        Weight = 1490,
                        CarPicture = "https://a.d-cd.net/2f3261as-960.jpg",
                        BrandId = 2
                    },
                    new Car
                    {
                        CarName = "Skyline",
                        Power = 280,
                        Torque = 391,
                        Weight = 1550,
                        CarPicture = "http://www.jm-imports.co.uk/wp-content/uploads/2014/08/P1180507-r50.jpg",
                        BrandId = 3
                    },
                    new Car
                    {
                        CarName = "Almera",
                        Power = 136,
                        Torque = 304,
                        Weight = 1810,
                        CarPicture = "https://avatars.mds.yandex.net/get-verba/216201/2a000001609d4854aa78fb5aa43bb33b202a/cattouchret",
                        BrandId = 3
                    },
                    new Car
                    {
                        CarName = "Juke",
                        Power = 117,
                        Torque = 180,
                        Weight = 1700,
                        CarPicture = "https://avatars.mds.yandex.net/get-verba/1672712/2a0000016e264d6614f286156740fb461642/cattouchret",
                        BrandId = 3
                    },
                    new Car
                    {
                        CarName = "Qashqai",
                        Power = 140,
                        Torque = 240,
                        Weight = 1935,
                        CarPicture = "https://avatars.mds.yandex.net/get-verba/3587101/2a0000017c0841cea3880c5c919daa78526a/cattouchret",
                        BrandId = 3
                    },
                    new Car
                    {
                        CarName = "RX7",
                        Power = 280,
                        Torque = 314,
                        Weight = 1490,
                        CarPicture = "https://avatars.mds.yandex.net/get-verba/787013/2a000001609d4ebfa1d761ed98e31eacbc80/cattouchret",
                        BrandId = 4
                    },
                    new Car
                    {
                        CarName = "Roadster",
                        Power = 131,
                        Torque = 150,
                        Weight = 1010,
                        CarPicture = "https://avatars.mds.yandex.net/get-verba/1535139/2a0000017f7948682bc163d5c597e0b66f08/cattouchret",
                        BrandId = 4
                    },
                    new Car
                    {
                        CarName = "Lancer",
                        Power = 168,
                        Torque = 226,
                        Weight = 1900,
                        CarPicture = "https://avatars.mds.yandex.net/get-verba/216201/2a000001608ff94d6fb037b5e586b1e36f6b/cattouchret",
                        BrandId = 5
                    });

                context.SaveChanges();
            }
        }
    }
}
