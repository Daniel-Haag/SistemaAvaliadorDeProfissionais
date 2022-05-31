using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Profissionais
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int profissionalID { get; set; }
        public string? nome { get; set; } 
        public string? userName { get; set; }
        public string? senha { get; set; }
        public string? matricula { get; set; }
        [ForeignKey("SetorID")]
        public Setores? setor { get; set; }

        [ForeignKey("CargoID")]       
        public Cargo? cargo { get; set; }
        public string? admissao { get; set; }
        [ForeignKey("StatusAvaliacaoID")]
        public StatusAvaliacao? statusAvaliacao { get; set; }
        public bool gestor { get; set; }
    }
}
