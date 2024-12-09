using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Entity.Utils;

namespace Entity.Entities
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
            CodigoPostal = codigoPostal;
        }

        private void SetCalle(string calle)
        {
            if (string.IsNullOrEmpty(calle))
            {
                throw new ArgumentNullException(FuncionesGenerales.DatoRequerido("Calle"));
            }
            else
            {
                Calle = calle;
            }
        }
        private void SetAltura(string altura)
        {

            if (string.IsNullOrEmpty(altura))
            {
                throw new ArgumentNullException(FuncionesGenerales.DatoRequerido("Altura"));
            }
            else
            {
                Altura = altura;
            }
        }
        public string GetSinCodigoPostal() => $"{Calle} {Altura}";
        public string GetConCodigoPostal() => $"{Calle} {Altura}, CP: {CodigoPostal}";
    }
}
