using StockControlSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.SupplierRepository
{
    public class MockSupplierData : IStockJournalRepository
    {
        private List<St_Stkjournal> stockJournals = new List<St_Stkjournal>()
        {
            new St_Stkjournal()
            {
                Stk_Coy = "company1",
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
                Stk_Coy = "company2",
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
            stockJournals.Add(stkJournal);

            return stkJournal;
        }

        public void DeleteStockJournal(St_Stkjournal stkJournal)
        {
            stockJournals.Remove(stkJournal);
        }

        public St_Stkjournal EditStockJournal(St_Stkjournal stkJournal)
        {
            var stockJournalInDb = GetStockJournal(stkJournal.Stk_Coy);

            stockJournalInDb.Stk_Branch = stkJournal.Stk_Branch;
            stockJournalInDb.Stk_Year = stkJournal.Stk_Year;
            stockJournalInDb.Stk_Month = stkJournal.Stk_Month;
            stockJournalInDb.Stk_Loc = stkJournal.Stk_Loc;
            stockJournalInDb.Stk_Type = stkJournal.Stk_Type;
            stockJournalInDb.Stk_Account = stkJournal.Stk_Account;
            stockJournalInDb.Stk_Debit = stkJournal.Stk_Debit;
            stockJournalInDb.Stk_Credit = stkJournal.Stk_Credit;
            stockJournalInDb.Stk_Rem = stkJournal.Stk_Rem;
            stockJournalInDb.Stk_Update = stkJournal.Stk_Update;
            stockJournalInDb.Stk_Period = stkJournal.Stk_Period;

            return stockJournalInDb;
        }

        public St_Stkjournal GetStockJournal(string company)
        {
            return stockJournals.SingleOrDefault(x => x.Stk_Coy == company);
        }

        public List<St_Stkjournal> GetStockJournals()
        {
            return stockJournals;
        }
    }
}
