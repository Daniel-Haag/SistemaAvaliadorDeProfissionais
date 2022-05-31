using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class PlanoDeAcao
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlanoDeAcaoID { get; set; }
        //[ForeignKey("ProfissionalID")]
        public Profissionais Profissional { get; set; }
        public string? TextoQuestao { get; set; }
        public string? TextoPlanoDeAcao { get; set; }
        [ForeignKey("PeriodoID")]
        public Periodos Periodo { get; set; }
        public string? ResultadoDaAcaoProposta { get; set; }
        public string? ConsideracoesFinaisDosPlanosDeAcao { get; set; }
        public string? ConsideracoesDoColaboradorAvaliado { get; set; }

    }
}
