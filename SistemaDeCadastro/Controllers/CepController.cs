using Microsoft.AspNetCore.Mvc;
using SistemaDeCadastro.Integracao.Interfaces;
using SistemaDeCadastro.Integracao.Response;

namespace SistemaDeCadastro.Controllers
{
    public class CepController : ControllerBase
    {
        private readonly IViaCepIntegracao _viaCepIntegracao;

        public CepController(IViaCepIntegracao viaCepIntegracao)
        { 
            _viaCepIntegracao = viaCepIntegracao;
        }


        [HttpGet("{cep}")]
        public async Task<ActionResult<ViaCepResponse>> ListarDadosEndereco(string cep)
        {

            var responseData = await _viaCepIntegracao.ObterDadosViaCep(cep);

            if (responseData == null)
            {

                return BadRequest("CEP não encontrado");
            }
            return Ok(responseData);

        }

    }
}
