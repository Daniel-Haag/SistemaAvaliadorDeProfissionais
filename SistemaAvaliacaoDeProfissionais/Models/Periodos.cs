using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Periodos
    {
        public int PeriodoID { get; set; }
        public int CodigoPeriodo { get; set; }
        public string Periodo { get; set; }
    }
}
