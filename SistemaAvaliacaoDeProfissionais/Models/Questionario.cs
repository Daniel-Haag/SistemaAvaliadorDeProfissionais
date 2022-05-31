using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Questionario
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestaoID { get; set; }
        public string Questao { get; set; }
        public string TituloQuestao { get; set; }
        [ForeignKey("TipoCargoID")]
        public TipoCargo? TipoCargo { get; set; }

    }
}
