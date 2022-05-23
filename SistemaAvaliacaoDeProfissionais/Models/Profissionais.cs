using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Profissionais
    {
        [Key]
        public string? profissionalID { get; set; }
        public string? nome { get; set; } 
        public string? userName { get; set; }
        public string? senha { get; set; }
        public string? matricula { get; set; }
        //[ForeignKey("SetorID")]
        //public string? setor { get; set; }

        [ForeignKey("CargoID")]       
        public Cargo? cargo { get; set; }
        public string? admissao { get; set; }
        //[ForeignKey("StatusAvaliacaoID")]
        //public string? statusAvaliacao { get; set; }
        public bool gestor { get; set; }
    }
}
