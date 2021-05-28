
using Document_vault.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dcvault_.Models
{
    public class Docs_detail
    {

        public int DocId { get; set; }
        
        public string DocType { get; set; }

        public int DateId { get; set; }

     
        public string DocTraffic { get; set; }
     
        public int ContactId { get; set; }
      
        public int ProfileId { get; set; }

       
        public string Subject { get; set; }
        
        public string PriorityLevel { get; set; }

        public int IsoNum { get; set; }
   
        public int StatusId { get; set; }
       
        public string ScannedDoc { get; set; }


        public IFormFile Image_ { get; set; }

       
        public virtual  Document_Date_Detail Document_Date_Detail { get; set; }

        public virtual Status_Details Status_Details { get; set; }

    }
}
