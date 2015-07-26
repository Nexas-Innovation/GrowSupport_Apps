namespace GrowUpNavi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MokuhyoTasseiHyoka
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string ShainCd { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string HyokaNendo { get; set; }

        [Required]
        [StringLength(3)]
        public string HyokaGroupCd { get; set; }

        [StringLength(3)]
        public string Mokuhyo1SbtCd { get; set; }

        [StringLength(50)]
        public string Mokuhyo1Naiyo { get; set; }

        [StringLength(3)]
        public string Mokuhyo2SbtCd { get; set; }

        [StringLength(50)]
        public string Mokuhyo2Naiyo { get; set; }

        [StringLength(3)]
        public string Mokuhyo3SbtCd { get; set; }

        [StringLength(50)]
        public string Mokuhyo3Naiyo { get; set; }

        [StringLength(3)]
        public string Mokuhyo4SbtCd { get; set; }

        [StringLength(50)]
        public string Mokuhyo4Naiyo { get; set; }

        [StringLength(3)]
        public string Mokuhyo5SbtCd { get; set; }

        [StringLength(50)]
        public string Mokuhyo5Naiyo { get; set; }

        [StringLength(400)]
        public string FurikaeriKeizoku { get; set; }

        [StringLength(400)]
        public string FurikaeriMondaiten { get; set; }

        [StringLength(400)]
        public string FurikaeriTry { get; set; }

        [StringLength(1000)]
        public string SoHyo { get; set; }

        [StringLength(4)]
        public string DisplayOrder { get; set; }

        [StringLength(4)]
        public string Hyokasha1Cd { get; set; }

        [StringLength(1000)]
        public string Hyokasha1Comment { get; set; }

        [StringLength(4)]
        public string Hyokasha2Cd { get; set; }

        [StringLength(1000)]
        public string Hyokasha2Comment { get; set; }

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

        public virtual M_HyokaGroup M_HyokaGroup { get; set; }

        public virtual M_MokuhyoSbt M_MokuhyoSbt { get; set; }

        public virtual M_MokuhyoSbt M_MokuhyoSbt1 { get; set; }

        public virtual M_MokuhyoSbt M_MokuhyoSbt2 { get; set; }

        public virtual M_MokuhyoSbt M_MokuhyoSbt3 { get; set; }

        public virtual M_MokuhyoSbt M_MokuhyoSbt4 { get; set; }

        public virtual M_Shain M_Shain { get; set; }

        public virtual M_Shain M_Shain1 { get; set; }

        public virtual M_Shain M_Shain2 { get; set; }
    }
}
