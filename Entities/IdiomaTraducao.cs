namespace CatalogoFilmes.Entities
{
    public class IdiomaTraducao
    {
        public int IdIdiomaTraducao {get; set;}
        public string Traducao { get; set;} = string.Empty;
        public int IdiomaId { get; set;}
        public Idioma Idioma {get; set;} = null!;
        public int CategoriaId{get;set;}
        public Categoria Categoria {get;set;} = null!;

    }
}