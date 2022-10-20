using System;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Must input a username.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5-15 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Must input a password.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6-20 characters.")]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6-20 characters.")]
        public string VerifyPassword { get; set; }
    }

}

