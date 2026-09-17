using System.ComponentModel.DataAnnotations;

namespace CatalogoFilmes.Entities
{
    public class PremioProducao
    {
        public int IdPremioProducao { get; set;}
        public int PremiacaoId { get; set;}
        public Premiacao Premiação { get ;set;} = null!;
        public TipoPremio TipoPremio { get;set;} = null!;

        public ICollection<Pessoa>Pessoas {get; set;}
        = new List<Pessoa>();
        
    }
}