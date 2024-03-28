using AutoMapper;
using BibliotecaAutoMapperAPI.Dto;
using BibliotecaAutoMapperAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaAutoMapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        public List<LivroModel> livros = new List<LivroModel>
        {
            new LivroModel 
            { 
                Id = 1,
                Titulo = "A Corte de Rosas e Espinhos",
                Autor = "Sarah J. Maas",
                ISBN = "SRM123456",
                DataCadastro = new DateTime(2024, 01, 17)
            },
            new LivroModel
            {
                Id = 2,
                Titulo = "A Corte de Névoa e Fúria",
                Autor = "Sarah J. Maas",
                ISBN = "JSM123456",
                DataCadastro = new DateTime(2023, 01, 17)
            },
            new LivroModel
            {
                Id = 3,
                Titulo = "A Corte de Asas e Ruínas",
                Autor = "Sarah J. Maas",
                ISBN = "VCH123456",
                DataCadastro = new DateTime(2022, 01, 17)
            },
            new LivroModel
            {
                Id = 4,
                Titulo = "A Corte de Chamas Prateadas",
                Autor = "Sarah J. Maas",
                ISBN = "DPRM123456",
                DataCadastro = new DateTime(2021, 01, 17)
            },
        };

        private readonly IMapper _mapper;
        public LivroController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("BuscaLivrosSemAutoMapper")]
        public ActionResult<List<LivroModel>> BuscaLivrosSemMapper()
        {
            return Ok(livros);
        }

        [HttpGet("BuscaLivrosComAutoMapper")]
        public ActionResult<List<LivroModel>> BuscaLivrosComAutoMapper()
        {
            //<O que eu quero que vire> (o que é)
            var livrosDto = _mapper.Map<List<LivroVisualizacaoDto>>(livros);

            return Ok(livrosDto);
        }

        [HttpPost]
        public ActionResult<List<LivroModel>> CriarLivro(LivroCadastroDto livro)
        {
            var livroModel = _mapper.Map<LivroModel>(livro);
            livroModel.Id = livros.Last().Id + 1;
            livros.Add(livroModel);

            return Ok(livros);
        }
    }
}
