namespace GrowUpNavi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MokuhyoTasseidoTashaHyoka
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string HiHyokaShainCd { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string HyokaNendo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string HyokaShainCd { get; set; }

        [StringLength(1000)]
        public string HyokaShainCmnt { get; set; }

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

        public virtual M_Shain M_Shain { get; set; }

        public virtual T_MokuhyoTasseidoJikoHyoka T_MokuhyoTasseidoJikoHyoka { get; set; }
    }
}
