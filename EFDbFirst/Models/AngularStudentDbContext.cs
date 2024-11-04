using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFDbFirst.Models;

public partial class AngularStudentDbContext : DbContext
{
    public AngularStudentDbContext()
    {
    }

    public AngularStudentDbContext(DbContextOptions<AngularStudentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<MarkSheet> MarkSheets { get; set; }

    public virtual DbSet<NewStduent> NewStduents { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Student> Students { get; set; }

 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasIndex(e => e.StudentId, "IX_Addresses_StudentId").IsUnique();

            entity.HasOne(d => d.Student).WithOne(p => p.Address).HasForeignKey<Address>(d => d.StudentId);
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Courses__C92D7187E0C4FDD1");

            entity.Property(e => e.CourseId)
                .ValueGeneratedNever()
                .HasColumnName("CourseID");
            entity.Property(e => e.CourseName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Dept__3213E83F842A78B3");

            entity.ToTable("Dept");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dept_name");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Emp__3213E83FDA15CE17");

            entity.ToTable("Emp");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DeptId).HasColumnName("dept_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");

            entity.HasOne(d => d.Dept).WithMany(p => p.Emps)
                .HasForeignKey(d => d.DeptId)
                .HasConstraintName("FK__Emp__dept_id__3E1D39E1");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<MarkSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MarkSheet");

            entity.Property(e => e.SubjectName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NewStduent>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__NewStdue__32C52A79FB1160B0");

            entity.ToTable("NewStduent");

            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("StudentID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Major)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("PRODUCTS");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasIndex(e => e.GenderId, "IX_Students_GenderId");

            entity.HasOne(d => d.Gender).WithMany(p => p.Students).HasForeignKey(d => d.GenderId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
