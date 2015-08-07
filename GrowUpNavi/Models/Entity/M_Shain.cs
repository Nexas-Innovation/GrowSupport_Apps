namespace GrowUpNavi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Shain
    {
        public M_Shain()
        {
            T_HyokaGroupBunrui = new HashSet<T_HyokaGroupBunrui>();
            T_HyoshoRireki = new HashSet<T_HyoshoRireki>();
            T_MokuhyoTasseidoJikoHyoka = new HashSet<T_MokuhyoTasseidoJikoHyoka>();
            T_MokuhyoTasseidoTashaHyoka = new HashSet<T_MokuhyoTasseidoTashaHyoka>();
            T_PasswdHenkoRireki = new HashSet<T_PasswdHenkoRireki>();
            T_SeichodoJikoHyoka = new HashSet<T_SeichodoJikoHyoka>();
            T_SeichodoTashaHyoka = new HashSet<T_SeichodoTashaHyoka>();
            T_ShoshinKokakuRireki = new HashSet<T_ShoshinKokakuRireki>();
            T_SosaRireki = new HashSet<T_SosaRireki>();
        }

        [Key]
        [StringLength(3)]
        public string ShainCd { get; set; }

        [Required]
        [StringLength(5)]
        public string Sei { get; set; }

        [Required]
        [StringLength(5)]
        public string Mei { get; set; }

        [Required]
        [StringLength(10)]
        public string SeiKana { get; set; }

        [Required]
        [StringLength(10)]
        public string MeiKana { get; set; }

        [Required]
        [StringLength(1)]
        public string SexCd { get; set; }

        [StringLength(8)]
        public string SeinenYmd { get; set; }

        [StringLength(255)]
        public string MailAdress { get; set; }

        [StringLength(13)]
        public string TelNo { get; set; }

        [StringLength(7)]
        public string YubinNo { get; set; }

        [StringLength(70)]
        public string Adress { get; set; }

        [Column(TypeName = "image")]
        public byte[] KaoShashin { get; set; }

        [Required]
        [StringLength(1)]
        public string GentaiKbnCd { get; set; }

        [StringLength(8)]
        public string NyushaYmd { get; set; }

        [StringLength(8)]
        public string TaishokuYmd { get; set; }

        [StringLength(3)]
        public string BushoCd { get; set; }

        [StringLength(3)]
        public string YakushokuCd { get; set; }

        [Required]
        [StringLength(64)]
        public string Password { get; set; }

        public int LoginFailedCt { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AccountLockDt { get; set; }

        [Required]
        [StringLength(1)]
        public string SystemAuthKbnCd { get; set; }

        [StringLength(50)]
        public string Biko { get; set; }

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

        public virtual M_Busho M_Busho { get; set; }

        public virtual M_GentaiKbn M_GentaiKbn { get; set; }

        public virtual M_Sex M_Sex { get; set; }

        public virtual M_SystemAuthKbn M_SystemAuthKbn { get; set; }

        public virtual M_Yakushoku M_Yakushoku { get; set; }

        public virtual ICollection<T_HyokaGroupBunrui> T_HyokaGroupBunrui { get; set; }

        public virtual ICollection<T_HyoshoRireki> T_HyoshoRireki { get; set; }

        public virtual ICollection<T_MokuhyoTasseidoJikoHyoka> T_MokuhyoTasseidoJikoHyoka { get; set; }

        public virtual ICollection<T_MokuhyoTasseidoTashaHyoka> T_MokuhyoTasseidoTashaHyoka { get; set; }

        public virtual ICollection<T_PasswdHenkoRireki> T_PasswdHenkoRireki { get; set; }

        public virtual ICollection<T_SeichodoJikoHyoka> T_SeichodoJikoHyoka { get; set; }

        public virtual ICollection<T_SeichodoTashaHyoka> T_SeichodoTashaHyoka { get; set; }

        public virtual ICollection<T_ShoshinKokakuRireki> T_ShoshinKokakuRireki { get; set; }

        public virtual ICollection<T_SosaRireki> T_SosaRireki { get; set; }
    }
}
