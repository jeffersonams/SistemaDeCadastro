using SistemaDeCadastro.Integracao.Response;

namespace SistemaDeCadastro.Integracao.Interfaces
{
    public interface IViaCepIntegracao
    {
        Task<ViaCepResponse> ObterDadosViaCep(string cep);

    }
}
