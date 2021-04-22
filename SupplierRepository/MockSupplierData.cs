using StockControlSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.SupplierRepository
{
    public class MockSupplierData : ISupplierRepository
    {
        private List<Supplier> suppliers = new List<Supplier>()
        {
            new Supplier()
            {
                Supcode = "supcode1",
                Name = "Supplier One",
                Address = "2 Ahmadu Bello Way, Lagos",
                Email = "supplier1@supcode1.com",
                Contact = "09076835398",
                PhoneNo = "08078866654",
                Sup_Last_Num = 01,
                Sup_Start_Date = DateTime.Now
            },
            new Supplier()
            {
                Supcode = "supcode2",
                Name = "Supplier Two",
                Address = "20 Ahmadu Bello Way, Lagos",
                Email = "supplier2@supcode2.com",
                Contact = "09076835398",
                PhoneNo = "08078866654",
                Sup_Last_Num = 02,
                Sup_Start_Date = DateTime.Now
            }
        };
        public Supplier AddSupplier(Supplier supplier)
        {
            Random random = new Random();

            supplier.Supcode = "supcode" + random.Next(0, 100).ToString();

            suppliers.Add(supplier);

            return supplier;
        }

        public void DeleteSupplier(Supplier supplier)
        {
            suppliers.Remove(supplier);
        }

        public Supplier EditSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public Supplier GetSupplier(string supcode)
        {
            return suppliers.SingleOrDefault(x => x.Supcode == supcode);
        }

        public List<Supplier> GetSuppliers()
        {
            return suppliers;
        }
    }
}
