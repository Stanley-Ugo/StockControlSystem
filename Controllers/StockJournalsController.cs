using Microsoft.AspNetCore.Mvc;
using StockControlSystem.Models;
using StockControlSystem.SupplierRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.Controllers
{
    public class StockJournalsController : Controller
    {
        private IStockJournalRepository _stockJournalRepository;

        public StockJournalsController(IStockJournalRepository stockJournalRepository)
        {
            _stockJournalRepository = stockJournalRepository;
        }

        [HttpGet]
        [Route("api/[controller]")]
        //https://localhost:44384/api/stockjournals
        public IActionResult GetStockJournals()
        {
            return Ok(_stockJournalRepository.GetStockJournals());
        }

        [HttpGet]
        [Route("api/[controller]/{company}")]
        //https://localhost:44384/api/stockjournals/company
        public IActionResult GetStockJournal(string company)
        {
            var stockCompany = _stockJournalRepository.GetStockJournal(company);

            if (stockCompany != null)
            {
                return Ok(stockCompany);
            }

            return NotFound($"The Stock Company With Company Name: {company} Was Not Found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        //https://localhost:44384/api/stockjournals
        public IActionResult AddStockJournal([FromBody] St_Stkjournal stkjournal)
        {
            _stockJournalRepository.AddStockJournal(stkjournal);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + stkjournal.Stk_Coy, stkjournal);
        }
    }
}
