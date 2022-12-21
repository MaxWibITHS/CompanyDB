using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public class CompanyClassDTO
    {   
        public int Id { get; set; }
        
        public string CompanyName { get; set; }
        
        public string Location { get; set; }
        
        public string OrgNumber { get; set; }
    }
}

