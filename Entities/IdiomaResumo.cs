namespace CatalogoFilmes.Entities
{
    public class IdiomaResumo
    {
        public int IdIdiomaResumo { get; set;}
        public string Sinopse { get; set;} = string.Empty;
        public int IdiomaId { get ;set;} 
        public Idioma Idioma { get; set;} = null!;
        public int ProducaoCinematograficaId { get; set;}
        public ProducaoCinematografica ProducaoCinematografica { get; set;} = null!;
    }
}