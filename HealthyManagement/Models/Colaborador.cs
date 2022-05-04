using System.Collections.Generic;

namespace HealthyManagement.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public ICollection<Orcamento> Orcamentos { get; set; } = new List<Orcamento>();

        public Colaborador()
        {
        }

        public Colaborador(int id, string nome, string cPF, string telefone)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Telefone = telefone;
        }
    }
}