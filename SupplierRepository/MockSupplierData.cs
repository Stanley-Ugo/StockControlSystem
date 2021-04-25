using StockControlSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.SupplierRepository
{
    public class MockSupplierData : IStockJournalRepository
    {
        private List<St_Stkjournal> stockJournal = new List<St_Stkjournal>()
        {
            new St_Stkjournal()
            {
                Stk_Coy = "Company1",
                Stk_Branch = "Branch 1",
                Stk_Year = "2021",
                Stk_Month = "April",
                Stk_Loc = "Aguda",
                Stk_Type = "Type 1",
                Stk_Account = "Account 1",
                Stk_Debit = 50.000M,
                Stk_Credit = 50.000M,
                Stk_Rem = "Company 1 was in the Building",
                Stk_Update = "Updating Company 1",
                Stk_Period = "The Period of Company 1",
            },

            new St_Stkjournal()
            {
                Stk_Coy = "Company2",
                Stk_Branch = "Branch 2",
                Stk_Year = "2021",
                Stk_Month = "April",
                Stk_Loc = "Aguda",
                Stk_Type = "Type 2",
                Stk_Account = "Account 2",
                Stk_Debit = 50.000M,
                Stk_Credit = 50.000M,
                Stk_Rem = "Company 2 was in the Building",
                Stk_Update = "Updating Company 2",
                Stk_Period = "The Period of Company 2",
            }
        };
        public St_Stkjournal AddStockJournal(St_Stkjournal stkJournal)
        {
            throw new NotImplementedException();
        }

        public void DeleteStockJournal(St_Stkjournal stkJournal)
        {
            throw new NotImplementedException();
        }

        public St_Stkjournal EditStockJournal(St_Stkjournal stkJournal)
        {
            throw new NotImplementedException();
        }

        public St_Stkjournal GetStockJournal(string company)
        {
            throw new NotImplementedException();
        }

        public List<St_Stkjournal> GetStockJournals()
        {
            throw new NotImplementedException();
        }
    }
}
