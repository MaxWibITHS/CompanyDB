using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Interfaces;

namespace Company.Data.Entities
{
    public class CompanyClass : IEntity
    {
        public int Id { get; set; }
        [MaxLength(20), Required]
        public string CompanyName { get; set; }
        [MaxLength(20), Required]
        public string Location { get; set; }
        [MaxLength(20), Required]
        public string OrgNumber { get; set; }
    }
}
