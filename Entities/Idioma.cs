namespace CatalogoFilmes.Entities
{
    public class Idioma
    {
        public int IdIdioma { get; set;}
        public string Lingua { get; set;} = string.Empty;
        public ICollection<Pais> Paises { get; set;}
        = new List<Pais>();
    }
}