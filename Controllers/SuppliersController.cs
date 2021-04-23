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
    public class SuppliersController : Controller
    {
        private ISupplierRepository _supplierRepo;
        private IMapper _mapper;

        public SuppliersController(ISupplierRepository supplierRepo, IMapper mapper)
        {
            _supplierRepo = supplierRepo;

            _mapper = mapper;
        }

        [HttpGet]
        [Route("api/[controller]")]
        //https://localhost:44384/api/suppliers
        public IActionResult GetSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            suppliers = _supplierRepo.GetSuppliers();

            var suppliersDTO = _mapper.Map<SupplierDTO>(suppliers);

            return Ok(suppliersDTO);
        }

        [HttpGet]
        [Route("api/[controller]/{supcode}")]
        //https://localhost:44384/api/suppliers/supcode
        public IActionResult GetSupplier(string supcode)
        {
            var supplier = _supplierRepo.GetSupplier(supcode);

            if (supplier != null)
            {
                var supplierDTO = _mapper.Map<SupplierDTO>(supplier);

                return Ok(supplierDTO);
            }

            return NotFound($"The Supplier With Supply Code: {supcode} Was Not Found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        //https://localhost:44384/api/suppliers/supcode
        public IActionResult AddSupplier([FromBody] SupplierDTO supplierDTO)
        {
            var supplier = _mapper.Map<Supplier>(supplierDTO);

            _supplierRepo.AddSupplier(supplier);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + supplierDTO.Supcode, supplierDTO);
        }

        [HttpDelete]
        [Route("api/[controller]/{supcode}")]
        //https://localhost:44384/api/suppliers/supcode
        public IActionResult DeleteSupplier(string supcode)
        {
            var supplier = _supplierRepo.GetSupplier(supcode);

            if (supplier != null)
            {
                _supplierRepo.DeleteSupplier(supplier);

                return Ok($"Supplier With Supply Code: {supcode} Has Been Deleted Successfully!!!");
            }

            return NotFound($"The Supplier With Supply Code: {supcode} Was Not Found");
        }

        [HttpPatch]
        [Route("api/[controller]/{supcode}")]
        //https://localhost:44384/api/suppliers/supcode
        public IActionResult EditSupplier(string supcode, [FromBody]SupplierDTO supplierDTO)
        {
            var supplierInDb = _supplierRepo.GetSupplier(supcode);

            if (supplierInDb != null)
            {
                supplierDTO.Supcode = supplierInDb.Supcode;

                var supplier = _mapper.Map<Supplier>(supplierDTO);

                _supplierRepo.EditSupplier(supplier);

                return Ok($"Supplier With Supply Code: {supcode} Has Been Edited Successfully!!!");
            }

            return NotFound($"The Supplier With Supply Code: {supcode} Was Not Found");
        }
    }
}
