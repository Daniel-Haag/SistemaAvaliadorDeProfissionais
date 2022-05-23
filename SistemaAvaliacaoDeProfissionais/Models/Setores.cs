using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Setores
    {
        [Key]
        public int setorID { get; set; }
        public string nomeSetor { get; set; }
    }
}
