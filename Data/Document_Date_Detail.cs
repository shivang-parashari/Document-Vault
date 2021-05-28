using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Document_vault.Data
{
    public class Document_Date_Detail
    {
        [Key]
       
       
        public int DateId { get; set; }
        [Required]
        public DateTime DateSent { get; set; }
        [Required]

        public DateTime DateReceived { get; set; }
        [Required]

        public DateTime ExpirationDate { get; set; }



    }
}
