namespace GrowUpNavi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Sex
    {
        public M_Sex()
        {
            M_Shain = new HashSet<M_Shain>();
        }

        [Key]
        [StringLength(1)]
        public string SexCd { get; set; }

        [Required]
        [StringLength(2)]
        public string Meisho { get; set; }

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

        public virtual ICollection<M_Shain> M_Shain { get; set; }
    }
}
