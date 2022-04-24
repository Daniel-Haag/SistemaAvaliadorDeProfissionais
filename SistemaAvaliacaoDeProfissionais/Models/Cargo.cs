using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Cargo
    {
        public int CargoID { get; set; }
        public string NomeCargo { get; set; }
        public TipoCargo TipoCargo { get; set; }
    }
}
