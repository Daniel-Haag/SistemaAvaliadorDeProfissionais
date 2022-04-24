using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class ResultadoAvaliacao
    {
        public int ResultadoAvaliacaoID { get; set; }
        public Profissionais Profissional { get; set; }
        public double NotaAutoAvaliacao { get; set; }
        public double NotaAvaliacao { get; set; }
        public DateTime DataAutoAvaliacao { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public Periodos Periodo { get; set; }
        public Profissionais Gestor { get; set; }
        public string Respostas { get; set; }
    }
}
