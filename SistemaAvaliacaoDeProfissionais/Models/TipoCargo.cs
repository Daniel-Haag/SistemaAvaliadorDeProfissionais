using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class TipoCargo
    {
        [Key]
        public int TipoCargoID { get; set; }
        public string NomeTipoCargo { get; set; }
    }
}
