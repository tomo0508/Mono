using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectMono.Service.Models
{
    public partial class VehicleContext : DbContext
    {
        public VehicleContext()
        {
        }

        public VehicleContext(DbContextOptions<VehicleContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<VehicleMake> VehicleMake { get; set; }
        public virtual DbSet<VehicleModel> VehicleModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");
         
            modelBuilder.Entity<VehicleMake>(entity =>
            {
                entity.Property(e => e.Abrv).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<VehicleModel>(entity =>
            {
                entity.Property(e => e.Abrv).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.HasOne(d => d.VehicleMake)
                    .WithMany(p => p.VehicleModels)
                    .HasForeignKey(d => d.MakeId)
                    .HasConstraintName("FK_dbo.VehicleModel_dbo.VehicleMake_Id");
            });
        }
    }
}
