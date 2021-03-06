﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.DTO.Products;
using WebStore.Domain.ViewModels;

namespace WebStore.Infrastructure.AutoMapper
{
    public class DTOMapping : Profile
    {
        public DTOMapping()
        {
            CreateMap<ProductDTO, ProductViewModel>().ReverseMap();
        }
    }
}
