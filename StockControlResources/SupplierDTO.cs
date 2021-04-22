using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.StockControlResources
{
    public class SupplierDTO
    {
        [StringLength(5, ErrorMessage = "Supply code can not be more than five characters!!!")]
        [Required]
        public string Supcode { get; set; }

        [StringLength(50, ErrorMessage = "Invalid Name Property!!!")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "Invalid Address Property!!!")]
        public string Address { get; set; }

        [StringLength(30, ErrorMessage = "Invalid Email Property!!!")]
        public string Email { get; set; }

        [StringLength(20, ErrorMessage = "Invalid Contact Property!!!")]
        public string Contact { get; set; }

        [StringLength(30, ErrorMessage = "Invalid Contact Property!!!")]
        public string PhoneNo { get; set; }
        public int? Sup_Last_Num { get; set; }
        public DateTime? Sup_Start_Date { get; set; }
    }
}
