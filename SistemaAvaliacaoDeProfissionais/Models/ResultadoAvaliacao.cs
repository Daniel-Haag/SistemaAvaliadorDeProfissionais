using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class ResultadoAvaliacao
    {
        [Key]
        public int ResultadoAvaliacaoID { get; set; }
        [ForeignKey("ProfissionalID")]
        public Profissionais Profissional { get; set; }
        public double? NotaAutoAvaliacao { get; set; }
        public double? NotaAvaliacao { get; set; }
        public DateTime? DataAutoAvaliacao { get; set; }
        public DateTime? DataAvaliacao { get; set; }
        [ForeignKey("PeriodoID")]
        public Periodos? Periodo { get; set; }
        public string? RespostasAutoAvaliacao { get; set; }
        public string? RespostasAvaliacao { get; set; }
    }
}
