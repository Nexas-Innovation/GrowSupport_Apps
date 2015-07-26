namespace GrowUpNavi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_MokuhyoSbt
    {
        public M_MokuhyoSbt()
        {
            T_MokuhyoTasseiHyoka = new HashSet<T_MokuhyoTasseiHyoka>();
            T_MokuhyoTasseiHyoka1 = new HashSet<T_MokuhyoTasseiHyoka>();
            T_MokuhyoTasseiHyoka2 = new HashSet<T_MokuhyoTasseiHyoka>();
            T_MokuhyoTasseiHyoka3 = new HashSet<T_MokuhyoTasseiHyoka>();
            T_MokuhyoTasseiHyoka4 = new HashSet<T_MokuhyoTasseiHyoka>();
        }

        [Key]
        [StringLength(3)]
        public string MokuhyoSbtCd { get; set; }

        [Required]
        [StringLength(10)]
        public string Meisho { get; set; }

        [Required]
        [StringLength(20)]
        public string Naiyo { get; set; }

        [Required]
        [StringLength(100)]
        public string MokuhyoJirei { get; set; }

        public int DisplayOrder { get; set; }

        [Required]
        [StringLength(1)]
        public string DelFlg { get; set; }

        [Required]
        [StringLength(4)]
        public string CrtKojinCd { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CrtDt { get; set; }

        [Required]
        [StringLength(10)]
        public string CrtPlgId { get; set; }

        [Required]
        [StringLength(4)]
        public string LastUpdKojinCd { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdKojinDt { get; set; }

        [Required]
        [StringLength(10)]
        public string LastUpdPlgId { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual ICollection<T_MokuhyoTasseiHyoka> T_MokuhyoTasseiHyoka { get; set; }

        public virtual ICollection<T_MokuhyoTasseiHyoka> T_MokuhyoTasseiHyoka1 { get; set; }

        public virtual ICollection<T_MokuhyoTasseiHyoka> T_MokuhyoTasseiHyoka2 { get; set; }

        public virtual ICollection<T_MokuhyoTasseiHyoka> T_MokuhyoTasseiHyoka3 { get; set; }

        public virtual ICollection<T_MokuhyoTasseiHyoka> T_MokuhyoTasseiHyoka4 { get; set; }
    }
}
