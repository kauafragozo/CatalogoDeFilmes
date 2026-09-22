namespace CatalogoFilmes.Entities
{
    public class Local
    {
        public int IdLocal { get; set;}
        public string Nome { get; set;} = string.Empty;
        public string CoordenadasGeograficas { get; set;} = string.Empty;
        public ICollection<Pais> Paises { get; set;}
        = new List<Pais>();
        public ICollection<ProducaoCinematografica> ProducoesCinematograficas { get; set;}
        = new List<ProducaoCinematografica>();
        
    }
}