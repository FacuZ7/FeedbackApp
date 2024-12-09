using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    //Temporalmente solo participantes, para hacer pruebas
    public interface IRepository
    {
        Task<Participante> GetByIdAsync(int id);
        Task<IEnumerable<Participante>> GetAll();
        Task AddAsync(Participante entity);
        //Task UpdateAsync(Participante entity);
        //Task DeleteAsync(Participante entity);

        //Task SaveAsync();

    }
}
