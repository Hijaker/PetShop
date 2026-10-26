using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Suppliers
    {
        [Key]
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public ICollection<Animals> Animal { get; set; }
    }
}
