namespace JhbMetro.Admin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tvMember_Results_JMC_Sel
    {
        [StringLength(20)]
        public string ChessaID { get; set; }

        [StringLength(120)]
        public string MemberSurname { get; set; }

        [StringLength(120)]
        public string MemberName { get; set; }

        [StringLength(10)]
        public string MemberGender { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string AgeGroup { get; set; }

        public int? RatingStandard { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MemberClub { get; set; }

        [StringLength(150)]
        public string TourName { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TourDate { get; set; }

        public decimal? PlayerAOR { get; set; }

        public decimal? PlayerPerf { get; set; }

        public int? RatedRounds { get; set; }

        public decimal? PlayerScore { get; set; }
    }
}
