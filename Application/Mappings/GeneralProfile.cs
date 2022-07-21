﻿using Application.Features.Products.Queries.GetAllProducts;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
  public class GeneralProfile: Profile
  {
    public GeneralProfile()
    {
      CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
      CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
      CreateMap<Image, GetAllProductsImageViewModel>();
    }
  }
}
