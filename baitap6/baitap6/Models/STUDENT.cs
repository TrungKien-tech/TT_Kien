namespace baitap6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STUDENT")]
    public partial class STUDENT
    {
        [Key]
        [StringLength(20)]
        public string MASV { get; set; }

        [StringLength(30)]
        public string TENSV { get; set; }

        public double? DTB { get; set; }

        public int? MAKHOA { get; set; }

        public virtual KHOA KHOA { get; set; }
    }
}
