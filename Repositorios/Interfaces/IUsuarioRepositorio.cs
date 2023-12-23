using WebApplication1.Models;

namespace WebApplication1.Repositorios.Interfaces
{
    // Vai ser responsavel por ter os contratos de usuario: buscar, remover, adicionar
    public interface IUsuarioRepositorio
    {
        //Task: assincrono
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);

    }
}
