using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFnal.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string NivelUsuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
