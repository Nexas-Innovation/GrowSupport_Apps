namespace GrowUpNavi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_ShoshinKokaku
    {
        public M_ShoshinKokaku()
        {
            T_ShoshinKokakuRireki = new HashSet<T_ShoshinKokakuRireki>();
        }

        [Key]
        [StringLength(1)]
        public string ShoshinKokakuKbnCd { get; set; }

        [Required]
        [StringLength(2)]
        public string Meisho { get; set; }

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

        public virtual ICollection<T_ShoshinKokakuRireki> T_ShoshinKokakuRireki { get; set; }
    }
}
