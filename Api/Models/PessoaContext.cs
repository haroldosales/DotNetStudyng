using Microsoft.EntityFrameworkCore;

namespace Pessoa.Models
{
    public class PessoaContext : DbContext
    {

  public PessoaContext(DbContextOptions<PessoaContext> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; } = null!;
    }
    }
    
