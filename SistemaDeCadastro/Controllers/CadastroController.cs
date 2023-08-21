using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeCadastro.Models;
using SistemaDeCadastro.Repositorio.Interfaces;

namespace SistemaDeCadastro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ICadastroRepositorio _cadastroRepositorio;
        public UsuarioController(ICadastroRepositorio cadastroRepositorio)
        {
            _cadastroRepositorio = cadastroRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<CadastroModel>>> BuscarTodosCadastros()
        {
            List<CadastroModel> cadastros = await _cadastroRepositorio.BuscarTodosCadastros();
            return Ok(cadastros);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CadastroModel>> BuscarPorId(int id)
        {
            CadastroModel cadastro = await _cadastroRepositorio.BuscarPorId(id);
            return Ok(cadastro);
        }

        [HttpPost]
        public async Task<ActionResult<CadastroModel>> Cadastrar(CadastroModel cadastroModel)
        {
            CadastroModel cadastro = await _cadastroRepositorio.Adicionar(cadastroModel);
            return Ok(cadastro);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CadastroModel>> Atualizar(CadastroModel cadastroModel, int id)
        {
            cadastroModel.Id = id;
            CadastroModel cadastro = await _cadastroRepositorio.Atualizar(cadastroModel, id);
            return Ok(cadastro);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CadastroModel>> Apagar(int id)
        {
            bool apagado = await _cadastroRepositorio.Apagar(id);
            return Ok(apagado);
        }
      




    }
}
