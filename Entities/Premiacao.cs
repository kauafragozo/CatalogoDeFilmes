namespace CatalogoFilmes.Entities
{
    public class Premiacao
    {
        public int PremiacaoId {get; set;}
        public DateOnly DataPremiacao{get; set;}
        public int PremioId{get; set;}
        public Premio Premio {get; set;} = null!;
         public ICollection<PremioProducao> PremioProducoesP { get; set;}
        = new List<PremioProducao>();

    }
}