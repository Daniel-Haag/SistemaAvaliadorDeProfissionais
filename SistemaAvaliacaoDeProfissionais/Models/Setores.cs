using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Setores
    {
        [Key]
        public int SetorID { get; set; }
        public string NomeSetor { get; set; }
    }
}
