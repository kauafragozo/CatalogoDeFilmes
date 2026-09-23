namespace CatalogoFilmes.Entities
{
    public class Categoria
    {
        public int IdCategoria { get; set;}
        public string Descricao {get; set;} = string.Empty;
        public ICollection<ProducaoCinematografica> ProducoesCinematograficas { get; set;}
        = new List<ProducaoCinematografica>();
        

    }
}