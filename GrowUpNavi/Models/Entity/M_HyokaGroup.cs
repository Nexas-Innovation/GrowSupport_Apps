namespace GrowUpNavi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_HyokaGroup
    {
        public M_HyokaGroup()
        {
            T_HyokaGroupBunrui = new HashSet<T_HyokaGroupBunrui>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string HyokaNendo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string HyokaGroupCd { get; set; }

        [Required]
        [StringLength(15)]
        public string HyokaGroupName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public short? HierarchyLevel { get; set; }

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

        public virtual ICollection<T_HyokaGroupBunrui> T_HyokaGroupBunrui { get; set; }
    }
}
