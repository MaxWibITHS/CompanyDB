using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeSecondName { get; set; }
        public int Salary { get; set; }
        public bool UnionMember { get; set; }
        public int DepartmentID { get; set; }
       // public virtual DepartmentDTO Department { get; set; }
    }
}
