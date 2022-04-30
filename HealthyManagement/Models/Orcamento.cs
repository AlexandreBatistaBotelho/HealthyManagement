using System;
using HealthyManagement.Models.Enums;

namespace HealthyManagement.Models
{
    public class Orcamento
    {
        public int Codigo { get; set; }
        public Cliente Cliente { get; set; }
        public Colaborador Colaborador { get; set; }
        public SituacaoOrcamento situacaoOrcamento { get; set; }
        public DateTime dtCadastro { get; set; }
        public DateTime dtAgendado { get; set; }
    }
}