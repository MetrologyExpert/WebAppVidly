using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppVidly.Dtos;
using WebAppVidly.Models;

namespace WebAppVidly.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();

        }
    }
}