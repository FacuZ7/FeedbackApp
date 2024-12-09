using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class FeedbackAppDbContext : DbContext
    {
        public FeedbackAppDbContext(DbContextOptions<FeedbackAppDbContext> options) : base(options) 
        {   }

        public DbSet<Participante> Participante { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Participante>().ToTable("Participante");
            base.OnModelCreating(modelBuilder);
        }
    }
}
