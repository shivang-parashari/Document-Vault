using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data
{
    public class SignUp
    {
        [Key]
        [Required(ErrorMessage ="Please Enter your email")]
        [Display(Name ="Email address")]
        [EmailAddress(ErrorMessage ="Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a strong  password")]
        [Display(Name = "Password")]
        [Compare("ConfirmPassword" , ErrorMessage ="Password does not match")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm  password")]
        [Display(Name = "Conform Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }


    }
}
