using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoWayOut.Models.ViewModels.Users
{
    public class CreateAppUserViewModel
    {
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "User name")]
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

    }
}