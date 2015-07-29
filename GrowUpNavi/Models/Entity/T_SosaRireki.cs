namespace GrowUpNavi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SosaRireki
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SeqNo { get; set; }

        [Required]
        [StringLength(3)]
        public string ShainCd { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LoginDt { get; set; }

        [Required]
        [StringLength(40)]
        public string LoginIP { get; set; }

        [Required]
        [StringLength(2)]
        public string SosaKbnCd { get; set; }

        [Required]
        [StringLength(10)]
        public string CrtPlgId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SosaDt { get; set; }

        public virtual M_Shain M_Shain { get; set; }

        public virtual M_SosaKbn M_SosaKbn { get; set; }
    }
}
