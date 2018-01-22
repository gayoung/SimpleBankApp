using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBankApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User ID is required.")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "User ID must be 8-20 characters long.")]
        [RegularExpression(@"^Katherine|Maximilian|Washington$", ErrorMessage = "Please input a valid user ID.")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Password must be 10-20 characters long.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[%#*&!@])(([A-Za-z]{0,3}[^A-Za-z]+)*[A-Za-z]{0,3})$", ErrorMessage = "Please input a valid password.")]
        public string Password { get; set; }
    }
}