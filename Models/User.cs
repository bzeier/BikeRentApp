using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentApp.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public List<Bike> RentedBikes { get; set; }

        public float BankBalance { get; set; }

        public User(string email, string password, string userName, float bankBalance) {
            this.UserName = userName;
            this.Email = email;
            this.Password = password;
            this.BankBalance = bankBalance;
        }

    }
}
