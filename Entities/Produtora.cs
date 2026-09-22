namespace CatalogoFilmes.Entities
{
    public class Produtora
    {
        public int IdProdutora {get ; set;}
        public string Nome { get; set;} = string.Empty;

        public ICollection<ProducaoCinematografica> ProducoesCinematograficas { get ;set;}
        = new List<ProducaoCinematografica>();

        public ICollection<Pais> Paises { get; set;}
        = new List<Pais>();

    }
}