namespace DOANQUANLISINHVIEN.SQLSINHVIEN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINHVIEN")]
    public partial class SINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINHVIEN()
        {
            DANGKYMONHOC = new HashSet<DANGKYMONHOC>();
        }

        [Key]
        [StringLength(30)]
        public string MASV { get; set; }

        [StringLength(100)]
        public string HOTEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        public bool? GIOITINH { get; set; }

        [StringLength(50)]
        public string LOP { get; set; }

        [StringLength(100)]
        public string CHUYENNGANH { get; set; }

        [StringLength(15)]
        public string DIENTHOAI { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANGKYMONHOC> DANGKYMONHOC { get; set; }
    }
}
