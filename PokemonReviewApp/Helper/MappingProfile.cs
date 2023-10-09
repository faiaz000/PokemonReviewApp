using AutoMapper;
using PokemonReviewApp.Dtos;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
