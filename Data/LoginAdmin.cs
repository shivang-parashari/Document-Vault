using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace WebApplication2.Data
{
    public class LoginAdmin
    {
        [Key]
        [Required(ErrorMessage = "Please Enter your email")]
        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]

        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
