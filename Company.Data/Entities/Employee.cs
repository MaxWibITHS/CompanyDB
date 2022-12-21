using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Interfaces;

namespace Company.Data.Entities
{
    public class Employee : IEntity
    {
        public int Id { get; set;}
        [MaxLength(15), Required]
        public string EmployeeFirstName{ get; set;}
        [MaxLength(15), Required]
        public string EmployeeSecondName { get; set; }
        public int Salary { get; set; }
        public bool UnionMember { get; set; }
        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Position>? Positions { get; set; }

    }
}
