using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QLSV.Models;

public partial class QlsvContext : DbContext
{
    public QlsvContext()
    {
    }

    public QlsvContext(DbContextOptions<QlsvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Class> Classes { get; set; }
    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WINDOWS-PC\\VINHSHINDO;Database=QLSV;Integrated security=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK__Class__7577347ECDD22E88");

            entity.ToTable("Class");

            entity.Property(e => e.ClassId).HasColumnName("classId");
            entity.Property(e => e.ClassName)
                .HasMaxLength(255)
                .HasColumnName("className");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");
            entity.HasKey(e => e.studentId)
            .HasName("pk_studentId");
            entity.Property(e => e.studentId).UseIdentityColumn();
            entity.Property(e => e.studentName)
            .HasMaxLength(255)
           .HasColumnName("studentName");
            entity.Property(e => e.phone)
            .HasMaxLength(255)
            .HasColumnName("phone");
            entity.Property(e => e.email)
            .HasMaxLength(255)
           .HasColumnName("email");
            entity.HasOne(c => c.Class)
            .WithMany(s => s.Students)
           .HasForeignKey(c => c.classId)
           .HasConstraintName("fk_student_class");
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
