using Refit;
using SistemaDeCadastro.Integracao.Response;

namespace SistemaDeCadastro.Integracao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")] 
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);


    }
}
