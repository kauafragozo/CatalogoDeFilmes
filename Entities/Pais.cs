namespace CatalogoFilmes.Entities
{
    public class Pais
    {
        public int IdPais { get; set;}
        public string Nome { get; set;} = string.Empty;
        public string Nacionalidade { get; set;} = string.Empty;

        public ICollection<Premio> Premios { get ; set;}
         = new List<Premio>();

    }
}