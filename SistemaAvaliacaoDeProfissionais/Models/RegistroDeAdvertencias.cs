using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class RegistroDeAdvertencias
    {
        public int RegistroDeAdvertenciasID { get; set; }
        public Profissionais Profissional { get; set; }
        public DateTime DataAdvertencia { get; set; }
        public string Descricao { get; set; }
        public string CaminhoArquivo { get; set; }
        public PeriodoAvaliacao Periodo { get; set; }
    }
}
