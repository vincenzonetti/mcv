using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Veenca.Models;
using Veenca.Dtos;
namespace Veenca.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile() {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>();
            Mapper.CreateMap<membershipTypeDto, MembershipType>();
            Mapper.CreateMap<MembershipType, membershipTypeDto>();
            Mapper.CreateMap<GeneriDto, Genere>();
            Mapper.CreateMap<Genere, GeneriDto>();
        }
    }
}