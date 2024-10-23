using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Participante
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
        public Genero Genero { get; private set; }

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
                throw new ArgumentNullException("Nombre es un dato requerido");
            }
            else
            {
                this.Nombre = nombre;
            } 
        }

        private void SetApellido(string apellido)
        {
            if (string.IsNullOrEmpty(apellido))
            {
                throw new ArgumentNullException("Apellido es un dato requerido");
            }
            else
            {
                this.Apellido = apellido;
            }
        }

        private void SetFechaNacimiento(DateTime fechaNac)
        {
            if (DateTime.Now > fechaNac)
            {
                throw new Exception("Fecha de nacimiento no puede ser a futuro");
            }
            else
            {
                this.FechaNacimiento = fechaNac;
            }
        }

        public string GetNombreApellido() => $"{this.Nombre} {this.Apellido}";
        public string GetApellidoNombre() => $"{this.Apellido} {this.Nombre}";
        public int GetEdad() => (DateTime.Now.Year - this.FechaNacimiento.Year);
    }
}
