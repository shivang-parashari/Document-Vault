using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Document_vault.Data
{
    public class Admin
    {
       
        [Required]
        [DataType(DataType.EmailAddress)]
        public string AdminId{get; set;}

        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}
