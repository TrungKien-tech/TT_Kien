using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace baitap6.Models
{
    public partial class QUANLISINHVIEN : DbContext
    {
        public QUANLISINHVIEN()
            : base("name=QUANLISINHVIEN")
        {
        }

        public virtual DbSet<KHOA> KHOA { get; set; }
        public virtual DbSet<STUDENT> STUDENT { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<STUDENT>()
                .Property(e => e.MASV)
                .IsUnicode(false);
        }
    }
}
