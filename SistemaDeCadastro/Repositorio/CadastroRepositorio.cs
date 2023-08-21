using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro.Data;
using SistemaDeCadastro.Models;
using SistemaDeCadastro.Repositorio.Interfaces;

namespace SistemaDeCadastro.Repositorio
{
    public class CadastroRepositorio : ICadastroRepositorio
    {
        private readonly CadastroDBContext _dbContext;
        public CadastroRepositorio(CadastroDBContext cadastroDBContext)
        {
            _dbContext = cadastroDBContext;
        }

        public async Task<List<CadastroModel>> BuscarTodosCadastros()
        {
            return await _dbContext.Cadastros.ToListAsync();
        }

        public async Task<CadastroModel> BuscarPorId(int id)
        {
            return await _dbContext.Cadastros.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<CadastroModel> Adicionar(CadastroModel cadastro)
        {
            await _dbContext.Cadastros.AddAsync(cadastro);
            await _dbContext.SaveChangesAsync(); 

            return cadastro;
                
        }
        public async Task<CadastroModel> Atualizar(CadastroModel cadastro, int id)
        {
            CadastroModel cadastroPorId = await BuscarPorId(id);

            if (cadastroPorId == null)
            {
                throw new Exception($"Cadastro para o ID:{id} não foi encontrado.");
            }
            cadastroPorId.Nome = cadastro.Nome;
            cadastroPorId.Email = cadastro.Email;

            _dbContext.Cadastros.Update(cadastroPorId);
            await _dbContext.SaveChangesAsync();

            return cadastroPorId; 
        }

        public async Task<bool> Apagar(int id)
        {
            CadastroModel cadastroPorId = await BuscarPorId(id);

            if (cadastroPorId == null)
            {
                throw new Exception($"Cadastro para o ID:{id} não foi encontrado.");
            }

            _dbContext.Cadastros.Remove(cadastroPorId);
            await _dbContext.SaveChangesAsync();

            return true;


        }

        

        
        
    }
}
