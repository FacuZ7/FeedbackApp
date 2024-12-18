using Business.Interfaces;
using Business.Presenter;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    //En el video del curso, esta clase es GetBeerUseCase
    public class ParticipanteService<TEntity, TOutput>
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IPresenter<TEntity, TOutput> _presenter;

        public ParticipanteService(IRepository<TEntity> repository, IPresenter<TEntity, TOutput> presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task<TOutput> GetParticipante(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            return _presenter.Present(result);
        }

        public async Task<IEnumerable<TOutput>> GetTodosParticipante()
        {
            var result = await _repository.GetAllAsync();
            return _presenter.Present(result);
        }
    }
}
