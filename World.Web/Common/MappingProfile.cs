using AutoMapper;
using World.Web.DTO;
using World.Web.Models;

namespace World.Web.Common
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<Country,CreateCountrydto>().ReverseMap();
        }
    }
    }
