using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers2._0
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }
    }
}
