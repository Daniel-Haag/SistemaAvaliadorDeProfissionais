using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class RegistroDeAdvertencias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegistroDeAdvertenciasID { get; set; }
        public DateTime DataAdvertencia { get; set; }
        public string? Descricao { get; set; }
        public string CaminhoArquivo { get; set; }
        public PeriodoAvaliacao Periodo { get; set; }
    }
}
