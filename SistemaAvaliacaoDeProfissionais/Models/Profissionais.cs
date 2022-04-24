using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Profissionais
    {
        public int ProfissionalID { get; set; }
        public string UserName { get; set; }
        public string Matricula { get; set; }
        public Setores Setor { get; set; }
        public Cargo Cargo { get; set; }
        public DateTime Admissao { get; set; }
        public string Superior { get; set; }
        public StatusAvaliacao StatusAvaliacao { get; set; }
        public TipoCargo TipoCargo { get; set; }
    }
}
