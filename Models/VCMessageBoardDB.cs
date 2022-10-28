using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VCMessageBoard.Models
{
    public partial class VCMessageBoardDB : DbContext
    {
        public VCMessageBoardDB()
            : base("name=VCMessageBoardDB")
        {
        }

        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .Property(e => e.StudentNum)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.Message1)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentNum)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Faculty)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Course)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
