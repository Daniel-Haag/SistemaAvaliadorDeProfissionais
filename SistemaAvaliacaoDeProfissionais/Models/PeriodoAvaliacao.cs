using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class PeriodoAvaliacao
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PeriodoAvaliacaoID{ get; set; }
        [ForeignKey("PeriodoID")]
        public Periodos Periodo { get; set; } 
        [ForeignKey("ProfissionalID")]
        public Profissionais Profissional{ get; set; }
        public DateTime? DataInicioAvaliacao { get; set; }
        public DateTime? DataInicioAutoAvaliacao { get; set; }
        public DateTime? DataExpiracaoAvaliacao { get; set; }
        public DateTime? DataExpiracaoAutoAvaliacao { get; set; }
        public bool AvaliacaoExpirada { get; set; }
        public bool Liberada { get; set; }

    }
}
