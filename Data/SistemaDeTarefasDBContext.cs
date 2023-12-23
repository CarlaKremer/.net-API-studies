using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class SistemaDeTarefasDBContext : DbContext
    {
        /*O construtor aceita opções de configuração para o contexto do banco de dados.
        Ele chama o construtor da classe base (DbContext) passando essas opções, garantindo que a inicialização básica do contexto do banco de dados seja realizada 
        corretamente.*/
        public SistemaDeTarefasDBContext(DbContextOptions<SistemaDeTarefasDBContext> options)
            :base(options)
        {
            
        }
    }
}
