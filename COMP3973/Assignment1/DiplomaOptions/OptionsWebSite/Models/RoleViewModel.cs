using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OptionsWebSite.Models
{
    public class RoleViewModel
    {
        [Required]
        public string RoleName { get; set; }

        public List<UserViewModel> Users { get; set; }
    }
}