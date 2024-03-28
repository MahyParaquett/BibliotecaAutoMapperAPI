using AutoMapper;
using BibliotecaAutoMapperAPI.Dto;
using BibliotecaAutoMapperAPI.Models;

namespace BibliotecaAutoMapperAPI.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<LivroModel, LivroVisualizacaoDto>();
            CreateMap<LivroCadastroDto, LivroModel>();
        }
    }
}
