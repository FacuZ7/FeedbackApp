using Business.Interfaces;
using Infrastructure_SQLServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Entity.Entities;

namespace Infrastructure
{
    public class Repository : IRepository<Entity.Entities.Participante>
    {
        private readonly FeedbackAppDbContext _context;

        public Repository(FeedbackAppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Entity.Entities.Participante entity)
        {
            var participanteModel = new Infrastructure_SQLServer.Models.Participante()
            {
                Nombre = entity.Nombre,
                Apellido = entity.Apellido,
                FechaNacimiento = entity.FechaNacimiento,
                GeneroId = entity.GeneroId,
            };
            
            await _context.Participante.AddAsync(participanteModel);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Entity.Entities.Participante>> GetAllAsync()
        {
            return await _context.Participante.Select(pAux => new Entity.Entities.Participante
            {
                ParticipanteId = pAux.ParticipanteId,
                Nombre = pAux.Nombre,
                Apellido = pAux.Apellido,
                FechaNacimiento = pAux.FechaNacimiento,
                GeneroId = pAux.GeneroId
            })
            .ToListAsync();
            
        }

        public async Task<Entity.Entities.Participante> GetByIdAsync(int id)
        {
            var participante = await _context.Participante.FindAsync(id);

            return new Entity.Entities.Participante
            {
                ParticipanteId = participante.ParticipanteId,
                Nombre = participante.Nombre,
                Apellido = participante.Apellido,
                FechaNacimiento = participante.FechaNacimiento,
                GeneroId = participante.GeneroId
            };

        }
    }
}
