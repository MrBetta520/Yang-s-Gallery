using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment12._2._2.ViewModels
{
    public class RegisterViewModel : LoginViewModel
    {
        [Required(ErrorMessage ="Please enter first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Please enter last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Please enter phone number")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }
        
        [Required(ErrorMessage = "Please enter email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
