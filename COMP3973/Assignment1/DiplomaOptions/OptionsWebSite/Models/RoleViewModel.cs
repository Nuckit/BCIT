using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OptionsWebSite.Models
{
    public class RoleViewModel
    {
        [Required]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

        [Display(Name = "User")]
        public string UserName { get; set; }

        public List<SelectListItem> UserList { get; set; }
    }
}