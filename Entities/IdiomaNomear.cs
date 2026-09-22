namespace CatalogoFilmes.Entities
{
    public class IdiomaNomear
    {
        public int IdIdiomaNomear { get ; set;}
        public string Titulo { get; set;} = string.Empty;
        public string Original { get; set;} = string.Empty;
        public int IdiomaId { get; set;}
        public Idioma Idioma { get; set;} = null!;
        public int ProducaoCinematograficaId { get; set;}
        public ProducaoCinematografica ProducaoCinematografica { get; set;} = null!;
        
    }
}