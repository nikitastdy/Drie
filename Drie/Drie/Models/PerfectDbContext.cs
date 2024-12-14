using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Drie.Models;

public partial class PerfectDbContext : DbContext
{
    public PerfectDbContext()
    {
    }

    public PerfectDbContext(DbContextOptions<PerfectDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Driver> Drivers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=127.0.0.1;database=PerfectDb;uid=root;pwd=12345", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.5.23-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Driver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("driver");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(45)
                .HasColumnName("address");
            entity.Property(e => e.Addresslife)
                .HasMaxLength(45)
                .HasColumnName("addresslife");
            entity.Property(e => e.Archive)
                .HasColumnType("tinyint(4)")
                .HasColumnName("archive");
            entity.Property(e => e.Company)
                .HasMaxLength(45)
                .HasColumnName("company");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .HasColumnName("email");
            entity.Property(e => e.Jobname)
                .HasMaxLength(45)
                .HasColumnName("jobname");
            entity.Property(e => e.Middlename)
                .HasMaxLength(45)
                .HasColumnName("middlename");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Passportnumber)
                .HasMaxLength(45)
                .HasColumnName("passportnumber");
            entity.Property(e => e.Passportserial)
                .HasMaxLength(45)
                .HasColumnName("passportserial");
            entity.Property(e => e.Phone)
                .HasMaxLength(45)
                .HasColumnName("phone");
            entity.Property(e => e.Photo)
                .HasMaxLength(45)
                .HasColumnName("photo");
            entity.Property(e => e.Surname)
                .HasMaxLength(45)
                .HasColumnName("surname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
