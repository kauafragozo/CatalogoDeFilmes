namespace CatalogoFilmes.Entities
{
    public class Pessoa
    {
        public int IdPessoa { get ;set;}
        public string Nome { get; set;} = string.Empty;
        
        public Pais Pais { get; set;} = null!;
        public ICollection<PremioProducao> PremioProducoes { get; set;}
       = new List<PremioProducao>();
    }
}