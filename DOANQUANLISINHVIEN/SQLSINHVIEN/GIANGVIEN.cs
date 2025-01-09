namespace DOANQUANLISINHVIEN.SQLSINHVIEN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIANGVIEN")]
    public partial class GIANGVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIANGVIEN()
        {
            DANGKYMONHOC = new HashSet<DANGKYMONHOC>();
            MONHOC = new HashSet<MONHOC>();
        }

        [Key]
        [StringLength(30)]
        public string MAGV { get; set; }

        [StringLength(100)]
        public string HOTEN { get; set; }

        public bool? GIOITINH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(15)]
        public string DIENTHOAI { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANGKYMONHOC> DANGKYMONHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MONHOC> MONHOC { get; set; }
    }
}
