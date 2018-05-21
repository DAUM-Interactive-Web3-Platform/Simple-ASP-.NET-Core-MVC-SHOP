using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.ViewModels
{
    public class EditRoleViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Please enter the role name")]
        [Display(Name ="Role Name")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
