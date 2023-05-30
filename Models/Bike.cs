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

        public Bike(string name, string description, User owner, float pricePerHour)
        {
            this.Name = name;
            this.Description = description;
            this.Owner = owner;
            this.PricePerHour = pricePerHour;
        }
    }
}
