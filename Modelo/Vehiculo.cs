using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermisosAppForm.Modelo
{
    internal class Vehiculo
    {
        public string patente { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }

        public string anio { get; set; }

        public Contribuyente contribuyente { get; set; }

        public Vehiculo() { }
        public Vehiculo(string patente, string marca, string modelo, string anio, 
            Contribuyente contribuyente) { 
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
            this.contribuyente = contribuyente;
        }
    }
}
