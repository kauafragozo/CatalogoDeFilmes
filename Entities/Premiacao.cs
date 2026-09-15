namespace CatalogoFilmes.Entities
{
    public class Premiacao
    {
        public int PremiacaoId {get; set;}
        public DateOnly DataPremiacao{get; set;}

        public Premio? Premio {get; set;}

    }
}