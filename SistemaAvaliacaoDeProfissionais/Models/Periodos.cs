using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Periodos
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PeriodoID { get; set; }
        public int CodigoPeriodo { get; set; }
        public string Periodo { get; set; }
    }
}
