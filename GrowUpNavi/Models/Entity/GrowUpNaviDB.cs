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
        public virtual DbSet<M_MokuhyoSbt> M_MokuhyoSbt { get; set; }
        public virtual DbSet<M_Sex> M_Sex { get; set; }
        public virtual DbSet<M_Shain> M_Shain { get; set; }
        public virtual DbSet<M_ShoshinKokaku> M_ShoshinKokaku { get; set; }
        public virtual DbSet<M_SosaKbn> M_SosaKbn { get; set; }
        public virtual DbSet<M_SystemAuthKbn> M_SystemAuthKbn { get; set; }
        public virtual DbSet<M_Yakushoku> M_Yakushoku { get; set; }
        public virtual DbSet<T_HyoshoRireki> T_HyoshoRireki { get; set; }
        public virtual DbSet<T_MokuhyoTasseidoHyoka> T_MokuhyoTasseidoHyoka { get; set; }
        public virtual DbSet<T_PasswdHenkoRireki> T_PasswdHenkoRireki { get; set; }
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
                .HasMany(e => e.T_MokuhyoTasseidoHyoka)
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

            modelBuilder.Entity<M_MokuhyoSbt>()
                .Property(e => e.MokuhyoSbtCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_MokuhyoSbt>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_MokuhyoSbt>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_MokuhyoSbt>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_MokuhyoSbt>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_MokuhyoSbt>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_MokuhyoSbt>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_MokuhyoSbt>()
                .HasMany(e => e.T_MokuhyoTasseidoHyoka)
                .WithOptional(e => e.M_MokuhyoSbt)
                .HasForeignKey(e => e.Mokuhyo1SbtCd);

            modelBuilder.Entity<M_MokuhyoSbt>()
                .HasMany(e => e.T_MokuhyoTasseidoHyoka1)
                .WithOptional(e => e.M_MokuhyoSbt1)
                .HasForeignKey(e => e.Mokuhyo2SbtCd);

            modelBuilder.Entity<M_MokuhyoSbt>()
                .HasMany(e => e.T_MokuhyoTasseidoHyoka2)
                .WithOptional(e => e.M_MokuhyoSbt2)
                .HasForeignKey(e => e.Mokuhyo3SbtCd);

            modelBuilder.Entity<M_MokuhyoSbt>()
                .HasMany(e => e.T_MokuhyoTasseidoHyoka3)
                .WithOptional(e => e.M_MokuhyoSbt3)
                .HasForeignKey(e => e.Mokuhyo4SbtCd);

            modelBuilder.Entity<M_MokuhyoSbt>()
                .HasMany(e => e.T_MokuhyoTasseidoHyoka4)
                .WithOptional(e => e.M_MokuhyoSbt4)
                .HasForeignKey(e => e.Mokuhyo5SbtCd);

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
                .HasMany(e => e.T_HyoshoRireki)
                .WithRequired(e => e.M_Shain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_MokuhyoTasseidoHyoka)
                .WithRequired(e => e.M_Shain)
                .HasForeignKey(e => e.ShainCd)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_MokuhyoTasseidoHyoka1)
                .WithOptional(e => e.M_Shain1)
                .HasForeignKey(e => e.Hyokasha1Cd);

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_MokuhyoTasseidoHyoka2)
                .WithOptional(e => e.M_Shain2)
                .HasForeignKey(e => e.Hyokasha2Cd);

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_PasswdHenkoRireki)
                .WithRequired(e => e.M_Shain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_ShoshinKokakuRireki)
                .WithRequired(e => e.M_Shain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_Shain>()
                .HasMany(e => e.T_SosaRireki)
                .WithRequired(e => e.M_Shain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<M_ShoshinKokaku>()
                .Property(e => e.ShoshinKokakuKbnCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_ShoshinKokaku>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_ShoshinKokaku>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_ShoshinKokaku>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_ShoshinKokaku>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_ShoshinKokaku>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<M_ShoshinKokaku>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<M_ShoshinKokaku>()
                .HasMany(e => e.T_ShoshinKokakuRireki)
                .WithRequired(e => e.M_ShoshinKokaku)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.ShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.HyokaNendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.HyokaGroupCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.Mokuhyo1SbtCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.Mokuhyo2SbtCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.Mokuhyo3SbtCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.Mokuhyo4SbtCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.Mokuhyo5SbtCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.DisplayOrder)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.Hyokasha1Cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.Hyokasha2Cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.DelFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.CrtShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.CrtPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.LastUpdShainCd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
                .Property(e => e.LastUpdPlgId)
                .IsUnicode(false);

            modelBuilder.Entity<T_MokuhyoTasseidoHyoka>()
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
