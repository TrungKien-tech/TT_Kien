namespace DOANQUANLISINHVIEN.SQLSINHVIEN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANGKYMONHOC")]
    public partial class DANGKYMONHOC
    {
        [Key]
        [StringLength(30)]
        public string MADK { get; set; }

        [StringLength(30)]
        public string TENMONHOC { get; set; }

        [StringLength(30)]
        public string MASV { get; set; }

        [StringLength(100)]
        public string HOTEN { get; set; }

        [StringLength(30)]
        public string MAGV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYDANGKY { get; set; }

        public virtual GIANGVIEN GIANGVIEN { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
