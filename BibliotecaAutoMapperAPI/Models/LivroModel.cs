namespace BibliotecaAutoMapperAPI.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }= string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string ISBN { get; set;} = string.Empty;
        public DateTime DataCadastro { get; set; } = DateTime.Now.Date;
    }
}
