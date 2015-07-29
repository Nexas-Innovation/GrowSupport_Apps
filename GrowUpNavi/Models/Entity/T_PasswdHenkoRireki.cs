namespace GrowUpNavi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_PasswdHenkoRireki
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SeqNo { get; set; }

        [Required]
        [StringLength(3)]
        public string ShainCd { get; set; }

        [StringLength(64)]
        public string Password { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? PasswordHenkoDt { get; set; }

        [Required]
        [StringLength(10)]
        public string CrtPlgId { get; set; }

        public virtual M_Shain M_Shain { get; set; }
    }
}
