using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._1
{
    internal class Ejercicio01Model
    {
        public string? DocumentoIngresado { get; set; }
        public string? NombreIngresado { get; set; }
        public string? ApellidoIngresado { get; set; }
        public DateTime? NacimientoIngresado { get; set; }

        public string Validar()
        {
            return "Ok";
        }
    }
}
