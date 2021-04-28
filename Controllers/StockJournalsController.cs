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

        [HttpDelete]
        [Route("api/[controller]/{company}")]
        //https://localhost:44384/api/stockjournals/company
        public IActionResult DeleteStockJournal(string company)
        {
            var stockCompany = _stockJournalRepository.GetStockJournal(company);

            if (stockCompany != null)
            {
                _stockJournalRepository.DeleteStockJournal(stockCompany);

                return Ok($"Stock Journal With Company Name: {company} Has Been Deleted Successfully!!!");
            }

            return NotFound($"The Stock Company With Company Name: {company} Was Not Found");
        }

        [HttpPatch]
        [Route("api/[controller]/{company}")]
        //https://localhost:44384/api/stockjournals/company
        public IActionResult EditStockJournal(string company, [FromBody] St_Stkjournal stkJournal)
        {
            var companyInDb = _stockJournalRepository.GetStockJournal(company);

            if (companyInDb != null)
            {
                stkJournal.Stk_Coy = companyInDb.Stk_Coy;
                stkJournal.Stk_Coy = companyInDb.Stk_Branch;
                stkJournal.Stk_Coy = companyInDb.Stk_Year;
                stkJournal.Stk_Coy = companyInDb.Stk_Month;
                stkJournal.Stk_Coy = companyInDb.Stk_Loc;
                stkJournal.Stk_Coy = companyInDb.Stk_Type;
                stkJournal.Stk_Coy = companyInDb.Stk_Account;

                _stockJournalRepository.EditStockJournal(stkJournal);

                return Ok($"Stock Journal With Company Name: {company} Has Been Edited Successfully!!!");
            }

            return NotFound($"The Stock Company With Company Name: {company} Was Not Found");
        }
    }
}
