using StockControlSystem.Models;
using StockControlSystem.StockControlContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.SupplierRepository
{
    public class SqlSupplierData : ISupplierRepository
    {
        private StockControlDBContext _stockControlContext;

        public SqlSupplierData(StockControlDBContext stockControlContext)
        {
            _stockControlContext = stockControlContext;
        }
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
            var supplierInDb = _stockControlContext.St_Supplier.SingleOrDefault(x => x.Supcode == supcode);

            return supplierInDb;
        }

        public List<Supplier> GetSuppliers()
        {
            var suppliersList =_stockControlContext.St_Supplier.ToList();

            return suppliersList;
        }
    }
}
