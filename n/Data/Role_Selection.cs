using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Document_vault.Data
{
    public class Role_Selection
    {
        [Key]
        [Required]
        public string RoleId { get; set; }
    }
}
