namespace JhbMetro.Admin.Model
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class Model : DbContext
	{
		public Model()
			: base("name=AdminModel")
		{
		}

		public virtual DbSet<zMember> zMembers { get; set; }
		public virtual DbSet<zTourEntry> zTourEntries { get; set; }
		public virtual DbSet<zTournament> zTournaments { get; set; }
		public virtual DbSet<zTourSection> zTourSections { get; set; }
		public virtual DbSet<zAgeGroup> zAgeGroups { get; set; }
		public virtual DbSet<zClub> zClubs { get; set; }
		public virtual DbSet<zUnion> zUnions { get; set; }
		public virtual DbSet<zUser> zUsers { get; set; }
		public virtual DbSet<tvChessaRatings_Agegroups_Sel> tvChessaRatings_Agegroups_Sel { get; set; }
		public virtual DbSet<tvJMC_Members_List_Sel> tvJMC_Members_List_Sel { get; set; }
		public virtual DbSet<tvMember_Results_JMC_Sel> tvMember_Results_JMC_Sel { get; set; }
		public virtual DbSet<tvTourEntries_Playerlist_Sel> tvTourEntries_Playerlist_Sel { get; set; }
		public virtual DbSet<tvTourReady_Sections_Sel> tvTourReady_Sections_Sel { get; set; }
		public virtual DbSet<tvTourReady_Sel> tvTourReady_Sel { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<tvMember_Results_JMC_Sel>()
				.Property(e => e.PlayerAOR)
				.HasPrecision(18, 0);

			modelBuilder.Entity<tvMember_Results_JMC_Sel>()
				.Property(e => e.PlayerPerf)
				.HasPrecision(18, 0);

			modelBuilder.Entity<tvMember_Results_JMC_Sel>()
				.Property(e => e.PlayerScore)
				.HasPrecision(18, 0);
		}
	}
}
