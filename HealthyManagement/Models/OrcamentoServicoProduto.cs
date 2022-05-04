namespace HealthyManagement.Models
{
    public class OrcamentoServicoProduto
    {
        public int Id { get; set; }
        public Orcamento Orcamento { get; set; }
        public ServicoProduto ServicoProduto { get; set; }
        public double Quantidade { get; set; }
        public TipoServico TipoServico { get; set; }

        public OrcamentoServicoProduto()
        {
        }

        public OrcamentoServicoProduto(int id, Orcamento orcamento, ServicoProduto servicoProduto, double quantidade, TipoServico tipoServico)
        {
            Id = id;
            Orcamento = orcamento;
            ServicoProduto = servicoProduto;
            Quantidade = quantidade;
            TipoServico = tipoServico;
        }
    }
}
