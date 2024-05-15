using System;

namespace Contatos.Domain.Models
{
    public class Contato : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string email)
        {
            ValidarCategoria(nome, email);
            this.Nome = nome;
            this.Email = email;
        }

        public void Update(string nome, string email)
        {
            ValidarCategoria(nome, email);
        }
        private void ValidarCategoria(string nome, string email)
        {
            if(string.IsNullOrEmpty(nome))
                throw new InvalidOperationException("o nome é inválido");
            if(string.IsNullOrEmpty(email));
        }
    }
}