using Entity.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Participante
    {
        public int ParticipanteId { get; set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
        public int GeneroId { get; private set; }

        public Participante(string nombre, string apellido, DateTime fechaNacimiento)
        {
            SetNombre(nombre);
            SetApellido(apellido);
            SetFechaNacimiento(fechaNacimiento);
        }

        private void SetNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentNullException(FuncionesGenerales.DatoRequerido("Nombre"));
            }
            else
            {
                Nombre = nombre;
            }
        }

        private void SetApellido(string apellido)
        {
            if (string.IsNullOrEmpty(apellido))
            {
                throw new ArgumentNullException(FuncionesGenerales.DatoRequerido("Apellido"));
            }
            else
            {
                Apellido = apellido;
            }
        }

        private void SetFechaNacimiento(DateTime fechaNac)
        {
            if (DateTime.Now < fechaNac)
            {
                throw new Exception(FuncionesGenerales.FechaPosteriorAHoy());
            }
            else
            {
                FechaNacimiento = fechaNac;
            }
        }

        public string GetNombreApellido() => $"{Nombre} {Apellido}";
        public string GetApellidoNombre() => $"{Apellido} {Nombre}";
        public int GetEdad() => DateTime.Now.Year - FechaNacimiento.Year;
    }
}
