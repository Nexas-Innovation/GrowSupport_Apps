namespace GrowUpNavi.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GrowUpNaviDB : DbContext
    {
        public GrowUpNaviDB()
            : base("name=GrowUpNaviDB")
        {
        }

        public virtual DbSet<M_Busho> M_Busho { get; set; }
        public virtual DbSet<M_GentaiKbn> M_GentaiKbn { get; set; }
        public virtual DbSet<M_HyokaGroup> M_HyokaGroup { get; set; }
        public virtual DbSet<M_HyoshoKbn> M_HyoshoKbn { get; set; }
        public virtual DbSet<M_SeichoHyokaLv> M_SeichoHyokaLv { get; set; }
        public virtual DbSet<M_SeichoHyokaPnt> M_SeichoHyokaPnt { get; set; }
        public virtual DbSet<M_SeichoMokuhyoSbt> M_SeichoMokuhyoSbt { get; set; }
        public virtual DbSet<M_Sex> M_Sex { get; set; }
        public virtual DbSet<M_Shain> M_Shain { get; set; }
        public virtual DbSet<M_ShoshinKokakuKbn> M_ShoshinKokakuKbn { get; set; }
        public virtual DbSet<M_SosaKbn> M_SosaKbn { get; set; }
        public virtual DbSet<M_SystemAuthKbn> M_SystemAuthKbn { get; set; }
        public virtual DbSet<M_TasseiMokuhyoSbt> M_TasseiMokuhyoSbt { get; set; }
        public virtual DbSet<M_Yakushoku> M_Yakushoku { get; set; }
        public virtual DbSet<T_HyokaGroupBunrui> T_HyokaGroupBunrui { get; set; }
        public virtual DbSet<T_HyoshoRireki> T_HyoshoRireki { get; set; }
        public virtual DbSet<T_JinendoTasseiMokuhyoSettei> T_JinendoTasseiMokuhyoSettei { get; set; }
        public virtual DbSet<T_MokuhyoTasseidoJikoHyoka> T_MokuhyoTasseidoJikoHyoka { get; set; }
        public virtual DbSet<T_MokuhyoTasseidoTashaHyoka> T_MokuhyoTasseidoTashaHyoka { get; set; }
        public virtual DbSet<T_PasswdHenkoRireki> T_PasswdHenkoRireki { get; set; }
        public virtual DbSet<T_SeichodoJikoHyoka> T_SeichodoJikoHyoka { get; set; }
        public virtual DbSet<T_SeichodoTashaHyoka> T_SeichodoTashaHyoka { get; set; }
        public virtual DbSet<T_ShoshinKokakuRireki> T_ShoshinKokakuRireki { get; set; }
        public virtual DbSet<T_SosaRireki> T_SosaRireki { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<M_Busho>()
                .Property(e => e.BushoCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Busho>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Busho>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Busho>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_Busho>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Busho>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_Busho>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_GentaiKbn>()
                .Property(e => e.GentaiKbnCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_GentaiKbn>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_GentaiKbn>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_GentaiKbn>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_GentaiKbn>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_GentaiKbn>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_GentaiKbn>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_GentaiKbn>()
                .HasMany(e => e.M_Shain)
                .WithRequired(e => e.M_GentaiKbn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_HyokaGroup>()
                .Property(e => e.HyokaNendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_HyokaGroup>()
                .Property(e => e.HyokaGroupCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_HyokaGroup>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_HyokaGroup>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_HyokaGroup>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_HyokaGroup>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_HyokaGroup>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_HyokaGroup>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_HyokaGroup>()
                .HasMany(e => e.T_HyokaGroupBunrui)
                .WithRequired(e => e.M_HyokaGroup)
                .HasForeignKey(e => new { e.HyokaNendo, e.HyokaGroupCd })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_HyoshoKbn>()
                .Property(e => e.HyoshoKbnCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_HyoshoKbn>()
                .Property(e => e.SosetsuNendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_HyoshoKbn>()
                .Property(e => e.HaishiNendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_HyoshoKbn>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_HyoshoKbn>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_HyoshoKbn>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_HyoshoKbn>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_HyoshoKbn>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_HyoshoKbn>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_HyoshoKbn>()
                .HasMany(e => e.T_HyoshoRireki)
                .WithRequired(e => e.M_HyoshoKbn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_SeichoHyokaLv>()
                .Property(e => e.SeichoHyokaPntCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaLv>()
                .Property(e => e.HyokaNendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaLv>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaLv>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaLv>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaLv>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaLv>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaLv>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            //modelBuilder.Entity<M_SeichoHyokaLv>()
            //    .HasMany(e => e.T_SeichodoJikoHyoka)
            //    .WithRequired(e => e.M_SeichoHyokaLv)
            //    .HasForeignKey(e => new { e.SeichoHyokaPntCd, e.HyokaNendo, e.SeichoHyokaLevel })
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_SeichoHyokaPnt>()
                .Property(e => e.SeichoHyokaPntCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaPnt>()
                .Property(e => e.HyokaNendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaPnt>()
                .Property(e => e.SeichoMokuhyoSbtCd1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaPnt>()
                .Property(e => e.SeichoMokuhyoSbtCd2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaPnt>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaPnt>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaPnt>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaPnt>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaPnt>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoHyokaPnt>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_SeichoHyokaPnt>()
                .HasMany(e => e.M_SeichoHyokaLv)
                .WithRequired(e => e.M_SeichoHyokaPnt)
                .HasForeignKey(e => new { e.SeichoHyokaPntCd, e.HyokaNendo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_SeichoMokuhyoSbt>()
                .Property(e => e.HyokaNendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoMokuhyoSbt>()
                .Property(e => e.SeichoMokuhyoSbtCd1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoMokuhyoSbt>()
                .Property(e => e.SeichoMokuhyoSbtCd2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoMokuhyoSbt>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoMokuhyoSbt>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoMokuhyoSbt>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoMokuhyoSbt>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoMokuhyoSbt>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_SeichoMokuhyoSbt>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_SeichoMokuhyoSbt>()
                .HasMany(e => e.M_SeichoHyokaPnt)
                .WithRequired(e => e.M_SeichoMokuhyoSbt)
                .HasForeignKey(e => new { e.HyokaNendo, e.SeichoMokuhyoSbtCd1, e.SeichoMokuhyoSbtCd2 })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_Sex>()
                .Property(e => e.SexCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Sex>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Sex>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Sex>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_Sex>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Sex>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_Sex>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_Sex>()
                .HasMany(e => e.M_Shain)
                .WithRequired(e => e.M_Sex)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.ShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.SexCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.SeinenYmd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.TelNo)
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.YubinNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.GentaiKbnCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.NyushaYmd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.TaishokuYmd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.BushoCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.YakushokuCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.Password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.SystemAuthKbnCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_Shain>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_HyokaGroupBunrui)
                .WithRequired(e => e.M_Shain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_HyoshoRireki)
                .WithRequired(e => e.M_Shain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_MokuhyoTasseidoJikoHyoka)
                .WithRequired(e => e.M_Shain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_MokuhyoTasseidoTashaHyoka)
                .WithRequired(e => e.M_Shain)
                .HasForeignKey(e => e.HyokaShainCd)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_PasswdHenkoRireki)
                .WithRequired(e => e.M_Shain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_SeichodoJikoHyoka)
                .WithRequired(e => e.M_Shain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_SeichodoTashaHyoka)
                .WithRequired(e => e.M_Shain)
                .HasForeignKey(e => e.HyokaShainCd)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_ShoshinKokakuRireki)
                .WithRequired(e => e.M_Shain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_SosaRireki)
                .WithRequired(e => e.M_Shain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_ShoshinKokakuKbn>()
                .Property(e => e.ShoshinKokakuKbnCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_ShoshinKokakuKbn>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_ShoshinKokakuKbn>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_ShoshinKokakuKbn>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_ShoshinKokakuKbn>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_ShoshinKokakuKbn>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_ShoshinKokakuKbn>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_SosaKbn>()
                .Property(e => e.SosaKbnCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SosaKbn>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SosaKbn>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SosaKbn>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_SosaKbn>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SosaKbn>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_SosaKbn>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_SosaKbn>()
                .HasMany(e => e.T_SosaRireki)
                .WithRequired(e => e.M_SosaKbn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_SystemAuthKbn>()
                .Property(e => e.SystemAuthKbnCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SystemAuthKbn>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SystemAuthKbn>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SystemAuthKbn>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_SystemAuthKbn>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_SystemAuthKbn>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_SystemAuthKbn>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_SystemAuthKbn>()
                .HasMany(e => e.M_Shain)
                .WithRequired(e => e.M_SystemAuthKbn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_TasseiMokuhyoSbt>()
                .Property(e => e.HyokaNendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_TasseiMokuhyoSbt>()
                .Property(e => e.TasseiMokuhyoSbtCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_TasseiMokuhyoSbt>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_TasseiMokuhyoSbt>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_TasseiMokuhyoSbt>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_TasseiMokuhyoSbt>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_TasseiMokuhyoSbt>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_TasseiMokuhyoSbt>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_TasseiMokuhyoSbt>()
                .HasMany(e => e.T_JinendoTasseiMokuhyoSettei)
                .WithOptional(e => e.M_TasseiMokuhyoSbt)
                .HasForeignKey(e => new { e.HyokaNendo, e.TasseiMokuhyoSbtCd });

            modelBuilder.Entity<M_Yakushoku>()
                .Property(e => e.YakushokuCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Yakushoku>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Yakushoku>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Yakushoku>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_Yakushoku>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_Yakushoku>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_Yakushoku>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_Yakushoku>()
                .HasMany(e => e.T_ShoshinKokakuRireki)
                .WithRequired(e => e.M_Yakushoku)
                .HasForeignKey(e => e.NinmeiYakushokuCd)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<T_HyokaGroupBunrui>()
                .Property(e => e.ShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_HyokaGroupBunrui>()
                .Property(e => e.HyokaNendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_HyokaGroupBunrui>()
                .Property(e => e.HyokaGroupCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_HyokaGroupBunrui>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_HyokaGroupBunrui>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_HyokaGroupBunrui>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_HyokaGroupBunrui>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_HyokaGroupBunrui>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_HyokaGroupBunrui>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<T_HyoshoRireki>()
                .Property(e => e.ShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_HyoshoRireki>()
                .Property(e => e.Nendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_HyoshoRireki>()
                .Property(e => e.HyoshoKbnCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_HyoshoRireki>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_HyoshoRireki>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_HyoshoRireki>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_HyoshoRireki>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_HyoshoRireki>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<T_JinendoTasseiMokuhyoSettei>()
                .Property(e => e.ShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_JinendoTasseiMokuhyoSettei>()
                .Property(e => e.HyokaNendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_JinendoTasseiMokuhyoSettei>()
                .Property(e => e.TasseiMokuhyoSbtCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_JinendoTasseiMokuhyoSettei>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_JinendoTasseiMokuhyoSettei>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_JinendoTasseiMokuhyoSettei>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_JinendoTasseiMokuhyoSettei>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_JinendoTasseiMokuhyoSettei>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_JinendoTasseiMokuhyoSettei>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<T_MokuhyoTasseidoJikoHyoka>()
                .Property(e => e.ShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoJikoHyoka>()
                .Property(e => e.HyokaNendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoJikoHyoka>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoJikoHyoka>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoJikoHyoka>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoJikoHyoka>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoJikoHyoka>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoJikoHyoka>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<T_MokuhyoTasseidoJikoHyoka>()
                .HasMany(e => e.T_JinendoTasseiMokuhyoSettei)
                .WithRequired(e => e.T_MokuhyoTasseidoJikoHyoka)
                .HasForeignKey(e => new { e.ShainCd, e.HyokaNendo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<T_MokuhyoTasseidoJikoHyoka>()
                .HasMany(e => e.T_MokuhyoTasseidoTashaHyoka)
                .WithRequired(e => e.T_MokuhyoTasseidoJikoHyoka)
                .HasForeignKey(e => new { e.HiHyokaShainCd, e.HyokaNendo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<T_MokuhyoTasseidoTashaHyoka>()
                .Property(e => e.HiHyokaShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoTashaHyoka>()
                .Property(e => e.HyokaNendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoTashaHyoka>()
                .Property(e => e.HyokaShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoTashaHyoka>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoTashaHyoka>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoTashaHyoka>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoTashaHyoka>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoTashaHyoka>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoTashaHyoka>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<T_PasswdHenkoRireki>()
                .Property(e => e.ShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_PasswdHenkoRireki>()
                .Property(e => e.Password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_PasswdHenkoRireki>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoJikoHyoka>()
                .Property(e => e.ShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoJikoHyoka>()
                .Property(e => e.HyokaNendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoJikoHyoka>()
                .Property(e => e.SeichoHyokaPntCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoJikoHyoka>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoJikoHyoka>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoJikoHyoka>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoJikoHyoka>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoJikoHyoka>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoJikoHyoka>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<T_SeichodoJikoHyoka>()
                .HasMany(e => e.T_SeichodoTashaHyoka)
                .WithRequired(e => e.T_SeichodoJikoHyoka)
                .HasForeignKey(e => new { e.HiHyokaShainCd, e.HyokaNendo, e.SeichoHyokaPntCd })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<T_SeichodoTashaHyoka>()
                .Property(e => e.HiHyokaShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoTashaHyoka>()
                .Property(e => e.HyokaNendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoTashaHyoka>()
                .Property(e => e.SeichoHyokaPntCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoTashaHyoka>()
                .Property(e => e.HyokaShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoTashaHyoka>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoTashaHyoka>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoTashaHyoka>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoTashaHyoka>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoTashaHyoka>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_SeichodoTashaHyoka>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<T_ShoshinKokakuRireki>()
                .Property(e => e.ShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_ShoshinKokakuRireki>()
                .Property(e => e.Nendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_ShoshinKokakuRireki>()
                .Property(e => e.ShoshinKokakuKbnCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_ShoshinKokakuRireki>()
                .Property(e => e.NinmeiYakushokuCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_ShoshinKokakuRireki>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_ShoshinKokakuRireki>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_ShoshinKokakuRireki>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_ShoshinKokakuRireki>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_ShoshinKokakuRireki>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<T_SosaRireki>()
                .Property(e => e.ShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SosaRireki>()
                .Property(e => e.LoginIP)
                .IsUnicode(false);

            modelBuilder.Entity<T_SosaRireki>()
                .Property(e => e.SosaKbnCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SosaRireki>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);
        }
    }
}
