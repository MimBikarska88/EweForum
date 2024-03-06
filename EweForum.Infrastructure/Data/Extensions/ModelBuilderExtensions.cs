using EweForum.Infrastructure.Data.Datasets.JsObjects;
using EweForum.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.EntityFrameworkCore.Metadata.Builders
{
    
    public static class ModelBuilderExtensions 
    {
       

        public static void SeedCountries(this ModelBuilder modelBuilder)
        {
            var json = File.ReadAllText("../EweForum.Infrastructure/Data/Datasets/countries.json");

            var countries = (CountryJs[])JsonConvert.DeserializeObject(json, typeof(CountryJs[]));
            List<Country>data = new List<Country>();
            foreach(var entry in countries)
            {
                data.Add(new Country
                {
                    Name = entry.Name,
                    Id = entry.Code,
                });
            }
            modelBuilder.Entity<Country>().HasData(data);
        }
    }
}
