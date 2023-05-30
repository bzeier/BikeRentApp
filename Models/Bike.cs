using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentApp.Models
{
    internal class Bike
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public User Owner { get; set; }

        public float PricePerHour { get; set; }

        public bool IsRentedOut { get; set; }

        public string ImageUrl { get; set; }

        public Bike(string name, string description, User owner, float pricePerHour, string imageUrl)
        {
            this.Name = name;
            this.Description = description;
            this.Owner = owner;
            this.PricePerHour = pricePerHour;
            this.IsRentedOut = false;
            this.ImageUrl = imageUrl;
        }
    }
}
