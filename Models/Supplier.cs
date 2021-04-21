using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.Models
{
    public class Supplier
    {
        public string Supcode { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        [Key, Column(Order = 0)]
        public string Email { get; set; }
        public string Contact { get; set; }

        [Key, Column(Order = 0)]
        public string PhoneNo { get; set; }
        public int Sup_Last_Num { get; set; }
        public DateTime Sup_Start_Date { get; set; }
    }
}
