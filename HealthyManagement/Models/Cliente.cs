using System.Collections.Generic;

namespace HealthyManagement.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public ICollection<Orcamento> Orcamentos { get; set; } = new List<Orcamento>();

        public Cliente()
        {
        }

        public Cliente(int id, string nome, string cPF, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Email = email;
            Telefone = telefone;
        }
    }
}