using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.Models
{
    public class St_Stkjournal
    {
		public string stk_coy { get; set; }
		public string stk_branch { get; set; }
		public string stk_year { get; set; }
		public string stk_month { get; set; }
		public string stk_loc { get; set; }
		public string stk_type { get; set; }
		public string stk_account { get; set; }
		public decimal stk_debit { get; set; }
		public decimal stk_credit { get; set; }
		public string stk_rem { get; set; }
		public string stk_update { get; set; }
		public string stk_period { get; set; }
	}
}
