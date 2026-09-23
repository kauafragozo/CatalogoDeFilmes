namespace CatalogoFilmes.Entities
{
    public class ProducaoCinematografica
    {
        public int IdProdCinematografica { get; set;}
        public string? Serie { get; set;}
        public int Ano {get;set;}
        public int Duracao { get; set;}
        public ICollection<Atuacao> Atuacoes { get; set;}
        = new List<Atuacao>();
        public ICollection<Produtora> Produtoras { get; set;}
        = new List<Produtora>();
        public ICollection<FaixaEtaria> FaixasEtarias {get; set;}
        = new List<FaixaEtaria>(); 
        public ICollection<Local> Locais { get; set;}
        = new List<Local>();
        public ICollection<Categoria> Categorias { get; set;}
        = new List<Categoria>();
        public ICollection<IdiomaNomear> IdiomasNomeas { get; set;}
        = new List<IdiomaNomear>();
        public ICollection<IdiomaResumo> IdiomasResumos { get; set;}
        = new List<IdiomaResumo>();
        

    }
}