using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Questionario
    {
        public int QuestaoID { get; set; }
        public string Questao { get; set; }
        public string TituloQuestao { get; set; }
        public TipoCargo TipoCargo { get; set; }

    }
}
