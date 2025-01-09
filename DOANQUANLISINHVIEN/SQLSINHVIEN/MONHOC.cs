namespace DOANQUANLISINHVIEN.SQLSINHVIEN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MONHOC")]
    public partial class MONHOC
    {
        [Key]
        public int MAMH { get; set; }

        [StringLength(100)]
        public string TENMH { get; set; }

        public int? SOTINCHI { get; set; }

        [StringLength(30)]
        public string MAGV { get; set; }

        public virtual GIANGVIEN GIANGVIEN { get; set; }
    }
}
