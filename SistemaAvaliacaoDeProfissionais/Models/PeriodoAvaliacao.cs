using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class PeriodoAvaliacao
    {
        public int PeriodoAvaliacaoID{ get; set; }
        public Periodos Periodo { get; set; } //codigoPeriodo
        public Profissionais Profissional{ get; set; }
        public DateTime DataInicioAvaliacao { get; set; }
        public DateTime DataInicioAutoAvaliacao { get; set; }
        public DateTime DataExpiracaoAvaliacao { get; set; }
        public DateTime DataExpiracaoAutoAvaliacao { get; set; }
        public bool AvaliacaoExpirada { get; set; }
        public bool Liberada { get; set; }

    }
}
