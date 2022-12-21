using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Interfaces;

namespace Company.Data.Entities
{
    public class Position : IEntity
    {
        public int Id { get; set; }
        [MaxLength(40), Required]
        public string PositionName { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
