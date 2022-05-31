using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class StatusAvaliacao
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int statusAvaliacaoID { get; set; }
        public string nomeStatusAvaliacao { get; set; }

    }
}
