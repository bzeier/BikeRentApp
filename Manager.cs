using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeRentApp.Models;

namespace BikeRentApp
{
    internal static class Manager
    {


        public static List<Bike> Catalogue = new List<Bike>();
        public static List<User> Users = new List<User>();
        public static Bike SelectedBike = null;
    }
}
