using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Document_vault.Data
{
    public class Status_Details
    {
        [Key]
        [Required]
        public int StatusId { get; set; }
        [Required]
        public string Viewed { get; set; }
        [Required]

        public string Replied { get; set; }
        [Required]
        public string Comments { get; set; }

        

    }
}
