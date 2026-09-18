using System.ComponentModel.DataAnnotations;

namespace CatalogoFilmes.Entities
{
    public class PremioProducao
    {
        public int IdPremioProducao { get; set;}
        public int PremiacaoId { get; set;}
        public Premiacao Premiacao { get ;set;} = null!;
        public int TipoPremioId{get; set;}
        public TipoPremio TipoPremio { get;set;} = null!;

        public ICollection<Pessoa>Pessoas {get; set;}
        = new List<Pessoa>();
        
    }
}