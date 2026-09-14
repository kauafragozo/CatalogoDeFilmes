namespace CatalogoFilmes.Entities
{
    public class Premio
    {
        public int IdPremio { get; set;}
        public string Descricao { get; set;} = string.Empty;

         public ICollection<Pais> Paises { get; set;}
          = new List<Pais>();
    }
}