using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata; // Comment

namespace Asisia.webapi.Models.DbDesign
{ // Comment
    public partial class DBDesignContext : DbContext
    {
        private readonly IHttpContextAccessor _contextAccessor;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<CustomMenu> CustomMenu { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Designes> Designes { get; set; } = null!;

        public DBDesignContext()  
        {
        }

        public DBDesignContext(DbContextOptions<DBDesignContext> options,
            IHttpContextAccessor contextAccessor) : base(options)
        {
            _contextAccessor = contextAccessor;
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = WebApplication.CreateBuilder();

                optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("DesignConnection"));
                optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomMenu>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__CUSTOM_M__3214EC26044063E3")
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.Parentid)
                    .HasConstraintName("FK__CUSTOM_ME__PAREN__29572725");
            });

            modelBuilder.Entity<Designes>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__DESIGNES__3214EC2656BB92A0")
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
