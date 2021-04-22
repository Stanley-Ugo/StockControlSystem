using AutoMapper;
using StockControlSystem.Models;
using StockControlSystem.StockControlResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Supplier, SupplierDTO>();

            CreateMap<SupplierDTO, Supplier>();
        }
    }
}
