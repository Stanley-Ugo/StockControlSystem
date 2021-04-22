using StockControlSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.SupplierRepository
{
    public class MockSupplierData : ISupplierRepository
    {
        public Supplier AddSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public void DeleteSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public Supplier EditSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public Supplier GetSupplier(string supcode)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetSuppliers()
        {
            throw new NotImplementedException();
        }
    }
}
