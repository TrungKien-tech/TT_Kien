using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DOANQUANLISINHVIEN.SQLSINHVIEN
{
    public partial class DEMOSINHVIEN : DbContext
    {
        public DEMOSINHVIEN()
            : base("name=DEMOSINHVIEN1")
        {
        }

        public virtual DbSet<DANGKYMONHOC> DANGKYMONHOC { get; set; }
        public virtual DbSet<DANGNHAP> DANGNHAP { get; set; }
        public virtual DbSet<GIANGVIEN> GIANGVIEN { get; set; }
        public virtual DbSet<MONHOC> MONHOC { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIEN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DANGKYMONHOC>()
                .Property(e => e.MADK)
                .IsUnicode(false);

            modelBuilder.Entity<DANGKYMONHOC>()
                .Property(e => e.MASV)
                .IsUnicode(false);

            modelBuilder.Entity<DANGKYMONHOC>()
                .Property(e => e.MAGV)
                .IsUnicode(false);

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.TAIKHOAN)
                .IsUnicode(false);

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.VAITRO)
                .IsUnicode(false);

            modelBuilder.Entity<GIANGVIEN>()
                .Property(e => e.MAGV)
                .IsUnicode(false);

            modelBuilder.Entity<GIANGVIEN>()
                .Property(e => e.DIENTHOAI)
                .IsUnicode(false);

            modelBuilder.Entity<GIANGVIEN>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<MONHOC>()
                .Property(e => e.MAGV)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MASV)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.DIENTHOAI)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);
        }
    }
}
