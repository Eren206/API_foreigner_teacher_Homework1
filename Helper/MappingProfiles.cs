using API_foreigner_teacher.Dto;
using API_foreigner_teacher.Models;
using AutoMapper;

namespace API_foreigner_teacher.Helper
{
    public class MappingProfiles :Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
