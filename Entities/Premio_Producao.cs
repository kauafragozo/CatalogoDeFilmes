using System.ComponentModel.DataAnnotations;

namespace CatalogoFilmes.Entities
{
    public class Premio_Producao
    {
        public int IdPremioProducao { get; set;}

        public int IdPremiacao { get; set;}
        public Premiacao Premiação { get ;set;} = null!;
    }
}