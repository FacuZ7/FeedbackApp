using Business.Presenter;
using Entity.Entities;
using Infrastructure_SQLServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_SQLServer.Presenters
{
    public class ParticipantePresenter : IPresenter<Entity.Entities.Participante, ParticipanteViewModel>
    {
        public IEnumerable<ParticipanteViewModel> Present(IEnumerable<Entity.Entities.Participante> data)
        {
            return data.Select(pAux => new ParticipanteViewModel
            {
                ParticipanteId = pAux.ParticipanteId,
                Nombre = pAux.Nombre,
                Apellido = pAux.Apellido,
                Edad = pAux.GetEdad(),
                NombreCompleto = pAux.GetNombreApellido()
            });
        }

        public ParticipanteViewModel Present(Entity.Entities.Participante data)
        {
            return new ParticipanteViewModel()
            {
                ParticipanteId = data.ParticipanteId,
                Nombre = data.Nombre,
                Apellido = data.Apellido,
                Edad = data.GetEdad(),
                NombreCompleto = data.GetNombreApellido()
            };
        }
    }
}
