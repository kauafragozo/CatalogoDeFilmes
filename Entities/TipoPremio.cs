using System.Runtime.InteropServices;

namespace CatalogoFilmes.Entities
{
    public class TipoPremio
    {
        public int IdTipoPremio { get; set; }
        public string Descricao { get; set; } = string.Empty;

        public ICollection<PremioProducao> PremioProducoes {get; set;}
        = new List<PremioProducao>();
    }
}