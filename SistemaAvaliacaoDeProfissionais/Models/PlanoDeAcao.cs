using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class PlanoDeAcao
    {
        public int PlanoDeAcaoID { get; set; }
        public Profissionais Profissional { get; set; }
        public Profissionais Gestor { get; set; }
        public string TextoQuestao { get; set; }
        public string TextoPlanoDeAcao { get; set; }
        public Periodos Periodo { get; set; }
        public string ResultadoDaAcaoProposta { get; set; }
        public string ConsideracoesFinaisDosPlanosDeAcao { get; set; }
        public string ConsideracoesDoColaboradorAvaliado { get; set; }

    }
}
