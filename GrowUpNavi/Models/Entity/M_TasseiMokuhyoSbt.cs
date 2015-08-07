namespace GrowUpNavi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_TasseiMokuhyoSbt
    {
        public M_TasseiMokuhyoSbt()
        {
            T_JinendoTasseiMokuhyoSettei = new HashSet<T_JinendoTasseiMokuhyoSettei>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string HyokaNendo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string TasseiMokuhyoSbtCd { get; set; }

        [Required]
        [StringLength(10)]
        public string Meisho { get; set; }

        [Required]
        [StringLength(20)]
        public string Naiyo { get; set; }

        [Required]
        [StringLength(100)]
        public string TasseiMokuhyoJirei { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        [StringLength(1)]
        public string DelFlg { get; set; }

        [Required]
        [StringLength(3)]
        public string CrtShainCd { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CrtDt { get; set; }

        [Required]
        [StringLength(10)]
        public string CrtPlgId { get; set; }

        [Required]
        [StringLength(3)]
        public string LastUpdShainCd { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdDt { get; set; }

        [Required]
        [StringLength(10)]
        public string LastUpdPlgId { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual ICollection<T_JinendoTasseiMokuhyoSettei> T_JinendoTasseiMokuhyoSettei { get; set; }
    }
}
