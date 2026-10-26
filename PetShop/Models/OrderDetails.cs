using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailID { get; set; }
        public Orders Order { get; set; }
        public Animals Animal { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal UnitPrice { get; set; }
    }
}
