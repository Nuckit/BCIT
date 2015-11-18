using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OptionsWebSite.Models
{
    public class RoleViewModel
    {
        [Required]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

        public List<UserViewModel> Users { get; set; }
    }
}