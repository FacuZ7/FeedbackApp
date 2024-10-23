using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Establecimiento
    {
        public string Descripcion {  get; set; }
        public TipoEstablecimiento TipoEstablecimiento { get; set; }
        public Ubicacion Ubicacion { get; set; }

        public Establecimiento(string descripcion, TipoEstablecimiento te, Ubicacion ub ) 
        {
            SetDescripcion(descripcion);
            SetTipoEstablecimiento(te);
            SetUbicacion(ub);
        }

        private void SetUbicacion(Ubicacion ub)
        {
            this.Ubicacion = ub;
        }

        private void SetTipoEstablecimiento(TipoEstablecimiento te)
        {
            this.TipoEstablecimiento = te;
        }

        private void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrEmpty(descripcion))
            {
                throw new ArgumentNullException("Descripcion es un dato requerido");
            }
            else
            {
                this.Descripcion = descripcion;
            }
        }
    }
}
