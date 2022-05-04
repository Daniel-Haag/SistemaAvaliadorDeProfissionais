using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Profissionais
    {
        [Key]
        public int ProfissionalID { get; set; }
        public string? Nome { get; set; } 
        public string? UserName { get; set; }
        public string? Senha { get; set; }
        public string Matricula { get; set; }
        [ForeignKey("SetorID")]
        public Setores Setor { get; set; }
        [ForeignKey("CargoID")]
        public Cargo Cargo { get; set; }
        public DateTime Admissao { get; set; }
        public Gestores Gestor { get; set; }
        [ForeignKey("StatusAvaliacaoID")]
        public StatusAvaliacao StatusAvaliacao { get; set; }
    }
}
