﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class ContactModel
    {
        [Display(Name = "İsim")]
        [Required(ErrorMessage = "{0} alanı doldurulması zorunlu bir alan")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }

        public string Message { get; set; }
    }
}