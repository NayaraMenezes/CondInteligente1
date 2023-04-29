using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    // [Table (Usuário)]

    public class Usuario
    {
        [Key]
        public int CodUsuario { get; set; }

        public int Cod_Tipo_Usuario { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome")]
        public String Nome { get; set; }

        public int Email { get; set; }
    }
}