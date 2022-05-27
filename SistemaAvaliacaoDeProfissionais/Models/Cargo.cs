using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Cargo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cargoID { get; set; }
        public string nomeCargo { get; set; }
        [ForeignKey("TipoCargoID")]
        public TipoCargo? tipoCargo { get; set; }
    }
}
