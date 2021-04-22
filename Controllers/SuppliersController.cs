using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetSuppliers()
        {
            return Ok(_supplierRepo.GetSuppliers());
        }
    }
}
