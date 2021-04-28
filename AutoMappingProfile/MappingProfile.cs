using AutoMapper;
using StockControlSystem.Models;
using StockControlSystem.StockControlResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControlSystem.AutoMappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Supplier, SupplierDTO>().ReverseMap();

            CreateMap<St_Stkjournal, Stk_JournalDTO>().ReverseMap();
        }
    }
}
