using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.Models
{
    [Table("St_Supplier")]
    public class Supplier
    {
        [Key, Column(Order = 0)]
        [StringLength(5, ErrorMessage = "Suply Code Can be More Than Five Characters!!!")]
        [Required]
        public string Supcode { get; set; }

        [Key, Column(Order = 1)]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string PhoneNo { get; set; }
        public int? Sup_Last_Num { get; set; }
        public DateTime? Sup_Start_Date { get; set; }
    }
}
