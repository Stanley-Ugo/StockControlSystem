using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StockControlSystem.Models;
using StockControlSystem.StockControlResources;
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
        private IMapper _mapper;

        public StockJournalsController(IStockJournalRepository stockJournalRepository, IMapper mapper)
        {
            _stockJournalRepository = stockJournalRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("api/[controller]")]
        //https://localhost:44384/api/stockjournals
        public IActionResult GetStockJournals()
        {
            List<St_Stkjournal> companyJournal = new List<St_Stkjournal>();

            companyJournal = _stockJournalRepository.GetStockJournals();

            var companyJournalDTO = _mapper.Map<List<Stk_JournalDTO>>(companyJournal);

            return Ok(companyJournalDTO);
        }

        [HttpGet]
        [Route("api/[controller]/{company}")]
        //https://localhost:44384/api/stockjournals/company
        public IActionResult GetStockJournal(string company)
        {
            var stockCompany = _stockJournalRepository.GetStockJournal(company);

            if (stockCompany != null)
            {
                var stockCompanyDTO = _mapper.Map<Stk_JournalDTO>(stockCompany);

                return Ok(stockCompanyDTO);
            }

            return NotFound($"The Stock Company With Company Name: {company} Was Not Found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        //https://localhost:44384/api/stockjournals
        public IActionResult AddStockJournal([FromBody] Stk_JournalDTO stkjournalDTO)
        {
            var stkjournal = _mapper.Map<St_Stkjournal>(stkjournalDTO);

            _stockJournalRepository.AddStockJournal(stkjournal);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + stkjournalDTO.Stk_Coy, stkjournalDTO);
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
        public IActionResult EditStockJournal(string company, [FromBody] Stk_JournalDTO stkJournalDTO)
        {
            var companyInDb = _stockJournalRepository.GetStockJournal(company);

            if (companyInDb != null)
            {
                stkJournalDTO.Stk_Coy = companyInDb.Stk_Coy;
                stkJournalDTO.Stk_Branch = companyInDb.Stk_Branch;
                stkJournalDTO.Stk_Year = companyInDb.Stk_Year;
                stkJournalDTO.Stk_Month = companyInDb.Stk_Month;
                stkJournalDTO.Stk_Loc = companyInDb.Stk_Loc;
                stkJournalDTO.Stk_Type = companyInDb.Stk_Type;
                stkJournalDTO.Stk_Account = companyInDb.Stk_Account;

                var stkJournal = _mapper.Map<St_Stkjournal>(stkJournalDTO);

                _stockJournalRepository.EditStockJournal(stkJournal);

                return Ok($"Stock Journal With Company Name: {company} Has Been Edited Successfully!!!");
            }

            return NotFound($"The Stock Company With Company Name: {company} Was Not Found");
        }
    }
}
