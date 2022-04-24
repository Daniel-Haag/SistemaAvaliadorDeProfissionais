using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class UsuariosExclusivos
    {
        [Key]
        public int UsuarioExclusivoID { get; set; }
        public string UsuarioLogin { get; set; }
        public string Senha { get; set; }
    }
}
