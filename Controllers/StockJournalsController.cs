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
    public class StockJournalsController : Controller
    {
        private IStockJournalRepository _stockJournalRepository;

        public StockJournalsController(IStockJournalRepository stockJournalRepository)
        {
            _stockJournalRepository = stockJournalRepository;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetStockJournals()
        {
            return Ok(_stockJournalRepository.GetStockJournals());
        }
    }
}
