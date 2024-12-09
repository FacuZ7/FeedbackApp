using Entity.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Establecimiento
    {
        public string Descripcion { get; set; }
        public TipoEstablecimiento TipoEstablecimiento { get; set; }
        public Ubicacion Ubicacion { get; set; }

        public Establecimiento(string descripcion, TipoEstablecimiento te, Ubicacion ub)
        {
            SetDescripcion(descripcion);
            SetTipoEstablecimiento(te);
            SetUbicacion(ub);
        }

        private void SetUbicacion(Ubicacion ub)
        {
            Ubicacion = ub;
        }

        private void SetTipoEstablecimiento(TipoEstablecimiento te)
        {
            TipoEstablecimiento = te;
        }

        private void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrEmpty(descripcion))
            {
                throw new ArgumentNullException($"{FuncionesGenerales.DatoRequerido("Descripcion")}");
            }
            else
            {
                Descripcion = descripcion;
            }
        }
    }
}
