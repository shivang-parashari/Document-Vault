using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Document_vault.Data
{
    public class Document_Detail
    {
        [Key]
        [Required]
        public int DocId { get; set; }
        [Required]
        public string DocType { get; set; }

        [Required]
        public int DateId { get; set; }

        [Required]
        public string DocTraffic { get; set; }
        [Required]
        public int ContactId { get; set;}
        [Required]
        public int ProfileId { get; set; }

        [Required]
        public string Subject { get; set; }
        [Required]
        public string PriorityLevel { get; set; }
        [Required]
        public int IsoNum { get; set; }
        [Required]
        public int StatusId { get; set; }
        [Required]
        public string ScannedDoc { get; set; }

        
      


        /**   [ForeignKey("ContactId")]
               public virtual Contact_Detail Contact_Detail { get; set; }

               [ForeignKey("ProfileId")]
               public virtual User_Profile_Details User_Profile_Details{ get; set; }  **/
           

               [ForeignKey("DateId")]
               public virtual Document_Date_Detail Document_Date_Detail{ get; set; }

               [ForeignKey("StatusId")]
               public virtual Status_Details Status_Details { get; set; }
          
               
    }
}
