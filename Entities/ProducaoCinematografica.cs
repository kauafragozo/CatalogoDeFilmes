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

    }
}