namespace CatalogoFilmes.Entities
{
    public class IdiomaLegenda
    {
        public int IdIdiomasLegenda {get; set; }
        public string Original { get; set;}= string.Empty;
        public int ProducaoCinematograficaId { get; set;}
        public ProducaoCinematografica ProducoesCinematograficas {get; set;} = null!;
        public int IdiomaId { get; set;}
        public Idioma Idiomas {get; set;} = null!;


    }
}