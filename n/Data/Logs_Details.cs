using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Document_vault.Data
{
    public class Logs_Details
    {
       [Key]
        public int LogId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Action { get; set; }

        [Required]
        public string Type { get; set; }
        [Required]
        public string Remarks { get; set; }


     [ForeignKey("UserId")]
     public virtual User_Details User_Details{ get; set; }




    }
}
