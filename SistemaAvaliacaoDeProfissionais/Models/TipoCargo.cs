using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class TipoCargo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tipoCargoID { get; set; }
        public string nomeTipoCargo { get; set; }
    }
}
