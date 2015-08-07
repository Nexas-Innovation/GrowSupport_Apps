namespace GrowUpNavi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_ShoshinKokakuRireki
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string ShainCd { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string Nendo { get; set; }

        [Required]
        [StringLength(1)]
        public string ShoshinKokakuKbnCd { get; set; }

        [Required]
        [StringLength(3)]
        public string NinmeiYakushokuCd { get; set; }

        [StringLength(50)]
        public string ShoshinKokakuJiyu { get; set; }

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

        public virtual M_Yakushoku M_Yakushoku { get; set; }
    }
}
