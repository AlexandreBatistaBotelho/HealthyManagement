using System.Collections.Generic;
using HealthyManagement.Models.Enums;

namespace HealthyManagement.Models
{
    public class ServicoProduto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public TipoVenda TipoVenda { get; set; }
        public ICollection<OrcamentoServicoProduto> OrcamentosServicosProdutos { get; set; } = new List<OrcamentoServicoProduto>();

        public ServicoProduto()
        {
        }

        public ServicoProduto(int id, string nome, string descricao, double preco, TipoVenda tipoVenda)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            TipoVenda = tipoVenda;
        }
    }
}