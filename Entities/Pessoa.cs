namespace CatalogoFilmes.Entities
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; } = string.Empty;

        public Pais? PaisMoradia { get; set;}

        public ICollection<PremioProducao> PremioProducoes { get; set; }
        = new List<PremioProducao>();

        public ICollection<Atuacao> Atuacoes { get; set; }
        = new List<Atuacao>();


    }
}