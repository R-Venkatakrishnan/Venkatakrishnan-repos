using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityFcore.Models
{
    public class prod
    {
        [Key]
        [Required]
        public int BillNumber { get; set; }
        public int CustomerID { get; set; }
        public int productID { get; set; }
    }
}
