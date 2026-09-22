namespace CatalogoFilmes.Entities
{
    public class Atuacao
    {
        public int IdAtuacao {get; set;}
        public string Papel { get; set;} = string.Empty;
        public int PessoaId{get; set;}
        public Pessoa Pessoa {get; set;} = null!;
        public TipoAtuacao TipoAtuacao { get ; set;} = null!;
        public int ProducaoCinematograficaId { get; set;} 
        public ProducaoCinematografica ProducaoCinematografica { get; set;} = null!;

    }
}