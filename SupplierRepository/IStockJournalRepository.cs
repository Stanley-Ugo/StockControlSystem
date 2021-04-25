using StockControlSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.SupplierRepository
{
    public interface IStockJournalRepository
    {
        List<St_Stkjournal> GetStockJournals();

        St_Stkjournal GetStockJournal(string company);

        St_Stkjournal AddStockJournal(St_Stkjournal stkJournal);

        void DeleteStockJournal(St_Stkjournal stkJournal);

        St_Stkjournal EditStockJournal(St_Stkjournal stkJournal);
    }
}
