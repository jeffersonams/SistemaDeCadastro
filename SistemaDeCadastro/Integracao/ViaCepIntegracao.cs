using SistemaDeCadastro.Integracao.Interfaces;
using SistemaDeCadastro.Integracao.Refit;
using SistemaDeCadastro.Integracao.Response;

namespace SistemaDeCadastro.Integracao
{
    public class ViaCepIntegracao : IViaCepIntegracao
    {
        private readonly IViaCepIntegracaoRefit _viaCepIntegracaoRefit;

        public ViaCepIntegracao(IViaCepIntegracaoRefit viaCepIntegracaoRefit)
        { 
            _viaCepIntegracaoRefit = viaCepIntegracaoRefit;
        }

        public async Task<ViaCepResponse> ObterDadosViaCep(string cep)
        {
           var respondeData = await _viaCepIntegracaoRefit.ObterDadosViaCep(cep);

            if (respondeData != null && respondeData.IsSuccessStatusCode)
            {
                return respondeData.Content;
            }

            return null;
        }
    }
}
