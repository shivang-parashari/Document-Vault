using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Document_vault.Data
{
    public class Contact_Detail
    {
        [Key]
        [Required]
        public int  ContactId{ get; set; }

        [Required]
        public int CompanyId { get; set; }
        public string ContactName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int ContactNo { get; set; }

        [Required]
        public string Position { get; set; }

  /**   [ForeignKey("CompanyId")]

       public virtual Company_Details Company_Detail { get; set; }


**/
    }
}
