using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class PersonaAcceso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Tipo { get; set; } // "Residente" o "Invitado"

        public string NombreCompleto => $"{Tipo} - {Nombre} {ApellidoPaterno} {ApellidoMaterno}";
    }
}
