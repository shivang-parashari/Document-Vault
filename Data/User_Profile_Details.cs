using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;

namespace Document_vault.Data
{
    public class User_Profile_Details
    {
        [Key]
        [Required]
        public int ProfileId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }
        [Required]

        public string Address { get; set; }
        [Required]
        public int Contact { get; set; }
        [Required]
        public string Position { get; set; }

        [Required]
        public string Image { get; set; }





     /**   [ForeignKey("UserId")]
        public virtual Login login { get; set; }**/


        [ForeignKey("CompanyId")]

        public virtual Company_Details Company_Details { get; set; }
    }
}
