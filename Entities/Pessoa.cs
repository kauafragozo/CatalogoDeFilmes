namespace CatalogoFilmes.Entities
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int PaisMoradiaId { get ;set;}
        public Pais? PaisMoradia { get; set;}
        public int PaisNascencaId {get; set;}
        public Pais PaisNacenca { get; set;} = null!;

        public int UsuarioId{ get; set;}
        public Usuario? Usuario { get; set;}
        public ICollection<PremioProducao> PremioProducoes { get; set; }
        = new List<PremioProducao>();
        public ICollection<Atuacao> Atuacoes { get; set; }
        = new List<Atuacao>();
        



    }
}