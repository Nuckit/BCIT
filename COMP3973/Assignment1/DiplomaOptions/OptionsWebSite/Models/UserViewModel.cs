using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OptionsWebSite.Models
{
    public class UserViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Lockout Enabled")]
        public bool LockoutEnabled { get; set; }

        //public List<RoleViewModel> Roles { get; set; }
    }
}