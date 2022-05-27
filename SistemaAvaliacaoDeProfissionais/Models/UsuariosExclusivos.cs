using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class UsuariosExclusivos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UsuarioExclusivoID { get; set; }
        public string UsuarioLogin { get; set; }
        public string Senha { get; set; }
    }
}
