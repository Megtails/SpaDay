using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SpaDay.Models
{
    [BindProperties]
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Id { get; }
        private static int nextID = 1;

        public User()
        {
            Id = nextID;
            nextID++;
        }

        public User(string name, string email, string password): this()
        {
            Name = name;
            Email = email;
            Password = password;
        }

    }
}
