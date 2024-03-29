﻿using System.ComponentModel.DataAnnotations;

namespace MVCEmail.Models
{
    public class ContactFormModel
    {
        [Required, Display(Name = "Name:")]
        public string FromName { get; set; }
        [Required, Display(Name = "Email:"), EmailAddress]
        public string FromEmail { get; set; }
        [Required, Display(Name = "Message:")]
        public string Message { get; set; }
    }
}