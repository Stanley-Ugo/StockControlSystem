using StockControlSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.SupplierRepository
{
    public interface ISupplierRepository
    {
        List<Supplier> GetSuppliers();

        Supplier GetSupplier(string supcode);

        Supplier AddSupplier(Supplier supplier);

        void DeleteSupplier(Supplier supplier);

        Supplier EditSupplier(Supplier supplier);
    }
}
