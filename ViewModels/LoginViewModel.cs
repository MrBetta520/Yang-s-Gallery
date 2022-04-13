using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment12._2._2.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter user name")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Please enter a valid password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
