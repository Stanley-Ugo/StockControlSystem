using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.Models
{
    public class St_Stkjournal
    {
		public string Stk_Coy { get; set; }
		public string Stk_Branch { get; set; }
		public string Stk_Year { get; set; }
		public string Stk_Month { get; set; }
		public string Stk_Loc { get; set; }
		public string Stk_Type { get; set; }
		public string Stk_Account { get; set; }
		public decimal Stk_Debit { get; set; }
		public decimal Stk_Credit { get; set; }
		public string Stk_Rem { get; set; }
		public string Stk_Update { get; set; }
		public string Stk_Period { get; set; }
	}
}
