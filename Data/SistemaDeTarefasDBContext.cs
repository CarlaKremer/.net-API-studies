using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class SistemaDeTarefasDBContext : DbContext
    {
        /*
         Entity Framework: facilita trabalhar com bd
        ORM vai fzer toda estrutura de entidade, e depois iremos criar bd e tabelas atravéz do código
        O construtor aceita opções de configuração para o contexto do banco de dados.
        Ele chama o construtor da classe base (DbContext) passando essas opções, garantindo que a inicialização básica do contexto do banco de dados seja realizada 
        corretamente.
        
        configurando tabelas:
         */
        public SistemaDeTarefasDBContext(DbContextOptions<SistemaDeTarefasDBContext> options)
            :base(options)
        {
            
        }
        
        //Representa a tabela Usuarios:
        public DbSet<UsuarioModel> Usuarios { get; set; }
        //Representa a tabela Tarefas:
        public DbSet<TarefaModel> Tarefas{ get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
            }
    }
}
