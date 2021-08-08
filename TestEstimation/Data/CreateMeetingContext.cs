using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestEstimation.Data
{
    public class CreateMeetingContext : DbContext
    {
        public DbSet<EstimationModels.Meeting> Meetings { get; set; }
        public CreateMeetingContext(DbContextOptions<CreateMeetingContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstimationModels.Meeting>().ToTable("Meetings");
            base.OnModelCreating(modelBuilder);
        }
    }
}
