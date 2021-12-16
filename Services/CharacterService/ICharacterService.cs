using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _NETWebAPIWithEF.Dtos.Character;
using _NETWebAPIWithEF.Models;

namespace _NETWebAPIWithEF.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
    }
}