using SistemaDeCadastro.Models;

namespace SistemaDeCadastro.Repositorio.Interfaces
{
    public interface ICadastroRepositorio
    {
        Task<List<CadastroModel>> BuscarTodosCadastros();

        Task<CadastroModel>BuscarPorId(int id);

        Task<CadastroModel> Adicionar(CadastroModel cadastro);

        Task<CadastroModel> Atualizar(CadastroModel cadastro, int id);

        Task<bool> Apagar(int id);
        

    }
}
