namespace GrowUpNavi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_JinendoTasseiMokuhyoSettei
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(3)]
        public string ShainCd { get; set; }

        [Required]
        [StringLength(4)]
        public string HyokaNendo { get; set; }

        [StringLength(3)]
        public string TasseiMokuhyoSbtCd { get; set; }

        [StringLength(50)]
        public string TasseiMokuhyoNaiyo { get; set; }

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

        public virtual M_TasseiMokuhyoSbt M_TasseiMokuhyoSbt { get; set; }

        public virtual T_MokuhyoTasseidoJikoHyoka T_MokuhyoTasseidoJikoHyoka { get; set; }
    }
}
