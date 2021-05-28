using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Document_vault.Data
{
    public class User_Details
    {
        [Key]

        [Required]

        public int UserId { get; set; }
        [Required]
       
       
        public string Username { get; set; }
        [Required]
        [MinLength(10)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }


    }
}
