using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Efcoretest2.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblHomeWork> TblHomeWorks { get; set; }

    public virtual DbSet<TblProductlist> TblProductlists { get; set; }

    public virtual DbSet<TblWindow> TblWindows { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DELL;Database=DotNetTraining;User Id=SA;Password=root;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblHomeWork>(entity =>
        {
            entity.HasKey(e => e.RollNo);

            entity.ToTable("Tbl_HomeWork");

            entity.Property(e => e.RollNo).HasColumnName("Roll_No");
            entity.Property(e => e.GitHubRepoLink)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.GitHubUserName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblProductlist>(entity =>
        {
            entity.HasKey(e => e.ProductId);

            entity.ToTable("Tbl_Productlist");

            entity.Property(e => e.CreatedByName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasComputedColumnSql("('P'+right('000'+CONVERT([varchar],[ProductId]),(3)))", false);
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblWindow>(entity =>
        {
            entity.ToTable("Tbl_Window");

            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
