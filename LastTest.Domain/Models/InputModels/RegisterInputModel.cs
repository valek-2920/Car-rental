﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastTest.Domain.Models.InputModels
{
    public class RegisterInputModel
    {
        [Required]
        [EmailAddress]
        [Remote(action: "checkemail", controller: "accounts", ErrorMessage = "Email already exists!")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password Confirmation")]
        [Compare(otherProperty: "Password")]
        public string PasswordConfirmation { get; set; }
    }
}
