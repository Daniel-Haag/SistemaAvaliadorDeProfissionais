using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Gestores
    {
        [Key]
        public int GestorID { get; set; }
        [ForeignKey("ProfissionalID")]
        public Profissionais Profissional { get; set; }
    }
}
