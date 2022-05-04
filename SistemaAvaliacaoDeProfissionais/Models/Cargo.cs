﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class Cargo
    {
        [Key]
        public int CargoID { get; set; }
        public string NomeCargo { get; set; }
        [ForeignKey("TipoCargoID")]
        public TipoCargo? TipoCargo { get; set; }
    }
}