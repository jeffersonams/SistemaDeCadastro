namespace SistemaDeCadastro.Models
{
    public class CadastroModel

    {
        public CadastroModel(string nome, string email)
        {
            Nome = nome;
            Email = email;
            DataCadastro = DateTime.Now;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set;}

        



    }
}
