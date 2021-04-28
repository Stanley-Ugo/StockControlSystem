using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.StockControlResources
{
    public class Stk_JournalDTO
    {
		[Required]
		[StringLength(5, ErrorMessage = "Invalid Company Name")]
		public string Stk_Coy { get; set; }

		[Required]
		[StringLength(2, ErrorMessage = "Invalid Branch Id")]
		public string Stk_Branch { get; set; }

		[Required]
		[StringLength(4, ErrorMessage = "Invalid Year")]
		public string Stk_Year { get; set; }

		[Required]
		[StringLength(2, ErrorMessage = "Invalid Month")]
		public string Stk_Month { get; set; }

		[Required]
		[StringLength(5, ErrorMessage = "Invalid Location")]
		public string Stk_Loc { get; set; }

		[Required]
		[StringLength(3, ErrorMessage = "Invalid Company Type")]
		public string Stk_Type { get; set; }

		[Required]
		[StringLength(15, ErrorMessage = "Invalid Account Details")]
		public string Stk_Account { get; set; }

		public decimal Stk_Debit { get; set; }
		public decimal Stk_Credit { get; set; }
		public string Stk_Rem { get; set; }
		public string Stk_Update { get; set; }
		public string Stk_Period { get; set; }
	}
}
