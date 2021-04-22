using Microsoft.AspNetCore.Mvc;
using StockControlSystem.Models;
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

        public SuppliersController(ISupplierRepository supplierRepo)
        {
            _supplierRepo = supplierRepo;
        }

        [HttpGet]
        [Route("api/[controller]")]
        //https://localhost:44384/api/suppliers
        public IActionResult GetSuppliers()
        {
            return Ok(_supplierRepo.GetSuppliers());
        }

        [HttpGet]
        [Route("api/[controller]/{supcode}")]
        //https://localhost:44384/api/suppliers/supcode
        public IActionResult GetSupplier(string supcode)
        {
            var supplier = _supplierRepo.GetSupplier(supcode);

            if (supplier != null)
            {
                return Ok(supplier);
            }

            return NotFound($"The Supplier With Supply Code: {supcode} Was Not Found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        //https://localhost:44384/api/suppliers/supcode
        public IActionResult GetSupplier([FromBody] Supplier supplier)
        {
            _supplierRepo.AddSupplier(supplier);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + supplier.Supcode, supplier);
        }
    }
}
