using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OptionsWebSite.Models
{
    public class UserViewModel
    {
        [Required]
        public string UserName { get; set; }

        public bool LockoutEnabled { get; set; }

        public List<RoleViewModel> Roles { get; set; }
    }
}