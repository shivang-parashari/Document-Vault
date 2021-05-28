using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dcvault_.Models
{
    public class userdetail
    {
        public int ProfileId { get; set; }


        public int UserId { get; set; }


        public int CompanyId { get; set; }


        public string Name { get; set; }


        public DateTime? Birthday { get; set; }


        public string Address { get; set; }

        public int Contact { get; set; }

        public string Position { get; set; }
       
        public IFormFile Image_ { get; set; }

        public string Image { get; set; }


    }
}
