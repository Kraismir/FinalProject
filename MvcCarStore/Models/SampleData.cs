using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcCarStore.Models;

namespace MvcCarStore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<CarStoreEntities>
    {
        protected override void Seed(CarStoreEntities context)
        {
            var brandList = new List<Brand>
            {
                new Brand {CarBrand = "Porshe"},
                new Brand {CarBrand = "BMW"},
                new Brand {CarBrand = "Lamborghini"},
                new Brand {CarBrand = "Renault"},
                new Brand {CarBrand = "Dodge"},
                new Brand {CarBrand = "Volkswagen"},
                new Brand {CarBrand = "Mercedes"},
                new Brand {CarBrand =  "Ford"}
            };

            new List<Car>
            {
                new Car { BrandName = brandList.Single( b => b.CarBrand == "Porshe"), Model = "911 Turbo", Color = "Black", Year = 2005, Price = 50, CarPicUrl = @"c:\users\kristr_\Documents\MY Documents\PROJECTS\MvcCarStore\MvcCarStore\Content\Cars\porshe 911 turbo.jpg"},
                new Car { BrandName = brandList.Single( b => b.CarBrand == "Lamborghini"), Model = "Aventador LP7004", Color = "Blue", Year = 2000, Price = 29, CarPicUrl = "~/Content/Cars/Lamborghini Aventador LP7004.jpg"},
                new Car { BrandName = brandList.Single( b => b.CarBrand == "BMW"), Model = "330i", Color = "Black", Year = 2010, Price = 22, CarPicUrl = "~/Content/Cars/BMW 330i.jpg"},
                new Car { BrandName = brandList.Single( b => b.CarBrand == "Lamborghini"), Model = "Murcielago LP6704", Color = "Yellow", Year = 2008, Price = 30, CarPicUrl = "~/Content/Cars/Lamborghini Murcielago LP6704.jpg"},
                new Car { BrandName = brandList.Single( b => b.CarBrand == "Dodge"), Model = "Viper SRT10", Color = "Grey/Blue", Year = 1968, Price = 26, CarPicUrl = "~/Content/Cars/Dodge Viper SRT10.jpg"},
                new Car { BrandName = brandList.Single( b => b.CarBrand == "Dodge"), Model = "Viper GTS Coupe", Color = "Red", Year = 2005, Price = 26, CarPicUrl = "~/Content/Cars/Dodge Viper GTS Coupe.jpg"},
                new Car { BrandName = brandList.Single( b => b.CarBrand == "BMW"), Model = "X5", Color = "Red", Year = 1995, Price = 26, CarPicUrl = "~/Content/Cars/BMW X5.jpg"},
                new Car { BrandName = brandList.Single( b => b.CarBrand == "Porshe"), Model = "964 TURBO", Color = "White", Year = 1990, Price = 26, CarPicUrl = "~/Content/Cars/PORSCHE 964 TURBO.jpg"},
                new Car { BrandName = brandList.Single( b => b.CarBrand == "Renault"), Model = "Twingo Gordini R.S Kit", Color = "Black", Year = 2007, Price = 34, CarPicUrl = "~/Content/Cars/Renault Twingo Gordini R.S Kit.jpg"},
                new Car { BrandName = brandList.Single( b => b.CarBrand == "Volkswagen"), Model = "Beetle Convertible", Color = "Blue", Year = 1960, Price = 26, CarPicUrl = "~/Content/Cars/Volkswagen Beetle Convertible.jpg"},
                new Car { BrandName = brandList.Single( b => b.CarBrand == "Ford"), Model = "Model T Convertible", Color = "Black", Year = 1908, Price = 360, CarPicUrl = "~/Content/Cars/Ford Model T Convertible.jpg"},
                new Car { BrandName = brandList.Single( b => b.CarBrand == "Mercedes"), Model = "Benz SLK Class", Color = "Red", Year = 2005, Price = 27, CarPicUrl = "~/Content/Cars/Mercedes Benz SLK Class.jpg"},
                new Car { BrandName = brandList.Single( b => b.CarBrand == "Ford"), Model = "Model T Pickup", Color = "Black", Year = 1925, Price = 101, CarPicUrl = "~/Content/Cars/Ford Model T Pickup 1925.jpg"},

            }.ForEach(a => context.Cars.Add(a));
        }
    }
}