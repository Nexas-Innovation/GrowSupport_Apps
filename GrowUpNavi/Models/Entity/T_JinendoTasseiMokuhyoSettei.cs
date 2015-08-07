namespace GrowUpNavi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_JinendoTasseiMokuhyoSettei
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string ShainCd { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string HyokaNendo { get; set; }

        [StringLength(3)]
        public string TasseiMokuhyoSbtCd { get; set; }

        [StringLength(50)]
        public string TasseiMokuhyoNaiyo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string DelFlg { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string CrtShainCd { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "datetime2")]
        public DateTime CrtDt { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string CrtPlgId { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(3)]
        public string LastUpdShainCd { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "datetime2")]
        public DateTime LastUpdDt { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(10)]
        public string LastUpdPlgId { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual M_TasseiMokuhyoSbt M_TasseiMokuhyoSbt { get; set; }

        public virtual T_MokuhyoTasseidoJikoHyoka T_MokuhyoTasseidoJikoHyoka { get; set; }
    }
}
