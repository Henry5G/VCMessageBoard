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

        public virtual DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>()
                .Property(e => e.message)
                .IsUnicode(false);
        }
    }
}
