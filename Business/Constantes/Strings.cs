using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Utils;

namespace Business.Constantes
{
    public static class Strings
    {
        public static string DatoRequerido(string dato) => $"{FuncionesGenerales.PrimeraLetraMayuscula(dato)} es un dato requerido";
    }
}
