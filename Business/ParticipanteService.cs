using Business.Interfaces;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    //En el video del curso, esta clase es GetBeerUseCase
    public class ParticipanteService
    {
        private readonly IRepository _repository;

        public ParticipanteService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<Participante> GetParticipante(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Participante>> GetTodosParticipante()
        {
            return await _repository.GetAll();
        }
    }
}
