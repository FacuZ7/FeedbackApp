using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ubicacion
    {
        public string Calle { get; private set; }
        public string Altura { get; private set; }
        public string? CodigoPostal { get; private set; }
        
        public Ubicacion(string calle, string altura)
        {
            SetCalle(calle);
            SetAltura(altura);
        }

        public Ubicacion(string calle, string altura, string codigoPostal) 
        {
            SetCalle(calle);
            SetAltura(altura);
            this.CodigoPostal = codigoPostal;
        }

        private void SetCalle(string calle)
        {
            if (String.IsNullOrEmpty(calle))
            {
                throw new ArgumentNullException("Calle es un dato requerido");
            }
            else 
            {
                this.Calle = calle;
            }
        }
        private void SetAltura(string altura)
        {

            if (String.IsNullOrEmpty(altura))
            {
                throw new ArgumentNullException("Altura es un dato requerido");
            }
            else
            {
                this.Altura = altura;
            }
        }
        public string GetSinCodigoPostal() => $"{this.Calle} {this.Altura}";
        public string GetConCodigoPostal() => $"{this.Calle} {this.Altura}, CP: {this.CodigoPostal}";
    }
}
