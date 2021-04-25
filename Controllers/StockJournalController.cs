using Microsoft.AspNetCore.Mvc;
using StockControlSystem.SupplierRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockJournalController : Controller
    {
        private IStockJournalRepository _stockJournalRepository;

        public StockJournalController(IStockJournalRepository stockJournalRepository)
        {
            _stockJournalRepository = stockJournalRepository;
        }


    }
}
