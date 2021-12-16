using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _NETWebAPIWithEF.Dtos.Character;
using _NETWebAPIWithEF.Models;
using AutoMapper;

namespace _NETWebAPIWithEF
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}