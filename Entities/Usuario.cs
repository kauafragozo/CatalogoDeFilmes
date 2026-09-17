namespace CatalogoFilmes.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set;}
        public string CPF { get ;set;} = string.Empty;
        public string Email { get ;set;} = string.Empty;
        public Pessoa Pessoa { get; set;}=null!;
        public ICollection<Pessoa> Pessoas { get; set;}
        = new List<Pessoa>();
        
    }
}