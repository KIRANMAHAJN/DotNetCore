using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotNetCore.Model
{
    public partial class EmployeeDataContext : DbContext
    {
        public EmployeeDataContext()
        {
        }

        public EmployeeDataContext(DbContextOptions<EmployeeDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblData> TblData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=KIRANPC\\SQLEXPRESS;Database=EmployeeData;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblData>(entity =>
            {
                entity.ToTable("tblData");

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
           