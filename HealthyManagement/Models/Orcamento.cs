using System;
using HealthyManagement.Models.Enums;
using System.Collections.Generic;

namespace HealthyManagement.Models
{
    public class Orcamento
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Colaborador Colaborador { get; set; }
        public SituacaoOrcamento SituacaoOrcamento { get; set; }
        public double ValorFinal { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAgendado { get; set; }

        public ICollection<OrcamentoServicoProduto> OrcamentosServicosProdutos { get; set; } = new List<OrcamentoServicoProduto>();

        public Orcamento()
        {
        }

        public Orcamento(int id, Cliente cliente, Colaborador colaborador, SituacaoOrcamento situacaoOrcamento, double valorFinal, string descricao, DateTime dtCadastro, DateTime dtAgendado)
        {
            Id = id;
            Cliente = cliente;
            Colaborador = colaborador;
            SituacaoOrcamento = situacaoOrcamento;
            ValorFinal = valorFinal;
            Descricao = descricao;
            DataCadastro = dtCadastro;
            DataAgendado = dtAgendado;
        }
    }
}