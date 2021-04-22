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
            _stockControlContext.St_Supplier.Add(supplier);

            _stockControlContext.SaveChanges();

            return supplier;
        }

        public void DeleteSupplier(Supplier supplier)
        {
            _stockControlContext.St_Supplier.Remove(supplier);

            _stockControlContext.SaveChanges();
        }

        public Supplier EditSupplier(Supplier supplier)
        {
            var supplierInDb = _stockControlContext.St_Supplier.SingleOrDefault(x => x.Supcode == supplier.Supcode);

            if (supplierInDb != null)
            {
                _stockControlContext.St_Supplier.Update(supplier);

                _stockControlContext.SaveChanges();
            }

            return supplier;
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
