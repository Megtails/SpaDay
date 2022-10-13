using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SpaDay.Models
{

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; }

        public User()
        {
            Date = DateTime.Today;
        }

        public User(string name, string email, string password): this()
        {
            Name = name;
            Email = email;
            Password = password;
        }


    }

}
