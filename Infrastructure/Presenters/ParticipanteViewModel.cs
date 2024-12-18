using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_SQLServer.Presenters
{
    public class ParticipanteViewModel
    {
        public int ParticipanteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int Edad {  get; set; }
        public string NombreCompleto { get; set; }
    }
}
