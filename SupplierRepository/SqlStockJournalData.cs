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
            
        }
    }
}
