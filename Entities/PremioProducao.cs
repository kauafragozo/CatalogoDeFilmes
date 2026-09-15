using System.ComponentModel.DataAnnotations;

namespace CatalogoFilmes.Entities
{
    public class PremioProducao
    {
        public int IdPremioProducao { get; set;}
        public Premiacao? Premiação { get ;set;}
        public TipoPremio? TipoPremio { get;set;}
    }
}