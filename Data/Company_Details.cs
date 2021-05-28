using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Document_vault.Data
{
    public class Company_Details
    {
        public int id { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [Required]
        public string  CompanyName { get; set; }

        [Required]
        public string CompanyAddress { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        
        public int ContactNumber{ get; set; }

        [Required]
        public string CompanyCategory { get; set; }

    }
}
