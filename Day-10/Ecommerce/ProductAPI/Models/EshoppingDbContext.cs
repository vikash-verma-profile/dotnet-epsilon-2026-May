using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Models;

public partial class EshoppingDbContext : DbContext
{
    public EshoppingDbContext()
    {
    }

    public EshoppingDbContext(DbContextOptions<EshoppingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<FinalOrder> FinalOrders { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<MyOrder> MyOrders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-CUO3FKB;Initial Catalog=EshoppingDB;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.CatName).HasMaxLength(50);
        });

        modelBuilder.Entity<FinalOrder>(entity =>
        {
            entity.ToTable("FinalOrder");

            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.OrderName).HasMaxLength(50);
            entity.Property(e => e.OrderPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderQuantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(200);
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.ToTable("Login");

            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<MyOrder>(entity =>
        {
            entity.ToTable("MyOrder");

            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.ProductPrice).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.ProductDiscount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductMrp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ProductMRP");
            entity.Property(e => e.ProductSellingPrice).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
