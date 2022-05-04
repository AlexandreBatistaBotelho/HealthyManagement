using System.Collections.Generic;

namespace HealthyManagement.Models
{
    public class TipoServico
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Percentual { get; set; }
        public ICollection<OrcamentoServicoProduto> OrcamentosServicosProdutos { get; set; } = new List<OrcamentoServicoProduto>();

        public TipoServico()
        {
        }

        public TipoServico(int id, string descricao, double percentual)
        {
            Id = id;
            Descricao = descricao;
            Percentual = percentual;
        }
    }
}