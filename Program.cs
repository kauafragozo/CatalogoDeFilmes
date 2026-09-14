using CatalogoFilmes.Context;
using CatalogoFilmes.Settings;

namespace CatalogoFilmes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Database.EnsureDeleted();
                Console.WriteLine("Criando Banco de Dados...");
                context.Database.EnsureCreated();
                Console.WriteLine("Banco de Dados Criado, Pressione qualquer tecla");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}




