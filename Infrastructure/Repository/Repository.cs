using Business.Interfaces;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class Repository : IRepository
    {
        private readonly FeedbackAppDbContext _context;

        public Repository(FeedbackAppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Participante entity)
        {
            await _context.Participante.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Participante>> GetAll()
        {
            return await _context.Participante.ToListAsync();
        }

        public async Task<Participante> GetByIdAsync(int id)
        {
            return await _context.Participante.FindAsync(id);
        }
    }
}
