namespace CatalogoFilmes.Entities
{
    public class FaixaEtaria
    {
        public int IdFaixaEtaria { get; set;}
        public int IdadeLimite { get; set;}

        public ICollection<Pais> Paises { get; set;}
        = new List<Pais>();
        public ICollection<ProducaoCinematografica> ProducoesCinematograficas { get; set;}
        = new List<ProducaoCinematografica>();
        

    }
}