using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Setores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int setorID { get; set; }
        public string nomeSetor { get; set; }
    }
}
