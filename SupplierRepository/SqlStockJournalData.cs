using StockControlSystem.Models;
using StockControlSystem.StockControlContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.SupplierRepository
{
    public class SqlStockJournalData : IStockJournalRepository
    {
        private StockControlDBContext _stockControlDBContext;

        public SqlStockJournalData(StockControlDBContext stockControlDBContext)
        {
            _stockControlDBContext = stockControlDBContext;
        }
        public St_Stkjournal AddStockJournal(St_Stkjournal stkJournal)
        {
            _stockControlDBContext.St_Stkjournals.Add(stkJournal);

            _stockControlDBContext.SaveChanges();

            return stkJournal;
        }

        public void DeleteStockJournal(St_Stkjournal stkJournal)
        {
            _stockControlDBContext.St_Stkjournals.Remove(stkJournal);

            _stockControlDBContext.SaveChanges();
        }

        public St_Stkjournal EditStockJournal(St_Stkjournal stkJournal)
        {
            var stockJournalInDb = _stockControlDBContext.St_Stkjournals.SingleOrDefault(x => x.Stk_Coy == stkJournal.Stk_Coy);

            if (stockJournalInDb != null)
            {
                stockJournalInDb.Stk_Debit = stkJournal.Stk_Debit;
                stockJournalInDb.Stk_Credit = stkJournal.Stk_Credit;
                stockJournalInDb.Stk_Rem = stkJournal.Stk_Rem;
                stockJournalInDb.Stk_Update = stkJournal.Stk_Update;
                stockJournalInDb.Stk_Period = stkJournal.Stk_Period;

                _stockControlDBContext.St_Stkjournals.Update(stockJournalInDb);

                _stockControlDBContext.SaveChanges();
            }

            return stkJournal;
        }

        public St_Stkjournal GetStockJournal(string company)
        {
            var stockJournal = _stockControlDBContext.St_Stkjournals.SingleOrDefault(x => x.Stk_Coy == company);

            return stockJournal;
        }

        public List<St_Stkjournal> GetStockJournals()
        {
            return _stockControlDBContext.St_Stkjournals.ToList();
        }
    }
}
