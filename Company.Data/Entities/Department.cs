using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Interfaces;

namespace Company.Data.Entities
{
    public class Department : IEntity
    {
        public int Id { get; set; }
        [MaxLength(20), Required]
        public string DepartmentName { get; set; }
        public int CompanyClassId { get; set; }
        public virtual CompanyClass CompanyClass { get; set; }

    }
}
