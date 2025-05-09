using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermisosAppForm.Modelo
{
    internal class Contribuyente
    {
        public string rut { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string nacionalidad { get; set; }

        public string comuna { get; set; }

        public Contribuyente() { }
        public Contribuyente(string rut, string nombre, string apellido, string nacionalidad, 
            string comuna) { 
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            this.comuna = comuna;
        }

    }
}
