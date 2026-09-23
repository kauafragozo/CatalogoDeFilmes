namespace CatalogoFilmes.Entities
{
    public class Idioma
    {
        public int IdIdioma { get; set; }
        public string Lingua { get; set; } = string.Empty;
        public ICollection<Pais> Paises { get; set; }
        = new List<Pais>();
        public ICollection<IdiomaNomear> IdiomasNomeas { get; set; }
        = new List<IdiomaNomear>();
        public ICollection<IdiomaTraducao> IdiomasTraducoes { get; set; }
        = new List<IdiomaTraducao>();
        public ICollection<IdiomaResumo> IdiomasResumos { get; set; }
        = new List<IdiomaResumo>();
        public ICollection<IdiomaLegenda> IdiomasLegendas { get; set; }
        = new List<IdiomaLegenda>();
    }
}