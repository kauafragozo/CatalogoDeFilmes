namespace CatalogoFilmes.Entities
{
    public class TipoAtuacao
    {
        public int IdTipoAtuacao { get; set;}
        public string Descricao { get; set;} = string.Empty;
        public ICollection <Atuacao> Atuacoes { get; set;}
        =new List<Atuacao>();

    }
}