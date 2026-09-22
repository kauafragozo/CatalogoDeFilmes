namespace CatalogoFilmes.Entities
{
    public class Pais
    {
        public int IdPais { get; set;}
        public string Nome { get; set;} = string.Empty;
        public string Nacionalidade { get; set;} = string.Empty;

        public ICollection<Premio> Premios { get ; set;}
         = new List<Premio>();
        public ICollection<Pessoa> PessoasMoradoras { get; set;}
        = new List<Pessoa>();
        public ICollection<Pessoa> PessoasNascenca { get; set;}
        = new List<Pessoa>();
        public ICollection<Produtora> Produtoras { get; set;}
        = new List<Produtora>();
        public ICollection<FaixaEtaria> FaixasEtarias {get; set;}
        =new List<FaixaEtaria>();
                   
    }
}