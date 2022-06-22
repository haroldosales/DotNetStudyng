using Microsoft.EntityFrameworkCore;

namespace Teste2.Model
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> pessoa) : base(pessoa)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; } = null!;

    }

}