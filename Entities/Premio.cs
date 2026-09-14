namespace CatalogoFilmes.Entities
{
    public class Premio
    {
        public int IdPremio { get; set;}
        public string Descricao { get; set;} = string.Empty;

        public Premiacao? Premiacao { get; set;}

         public ICollection<Pais> Paises { get; set;}
          = new List<Pais>();

       

    }
}