namespace DOANQUANLISINHVIEN.SQLSINHVIEN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANGNHAP")]
    public partial class DANGNHAP
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string TAIKHOAN { get; set; }

        [Required]
        [StringLength(20)]
        public string MATKHAU { get; set; }

        [StringLength(20)]
        public string VAITRO { get; set; }
    }
}
