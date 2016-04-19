namespace JhbMetro.Admin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tvChessaRatings_Agegroups_Sel
    {
        [StringLength(20)]
        public string ChessaID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PlayerBirthdate { get; set; }

        [StringLength(120)]
        public string PlayerName { get; set; }

        [StringLength(15)]
        public string PlayerInitial { get; set; }

        [StringLength(120)]
        public string PlayerSurname { get; set; }

        [StringLength(12)]
        public string ChessUnion { get; set; }

        [StringLength(4)]
        public string PlayerGender { get; set; }

        [StringLength(20)]
        public string PlayerTitle { get; set; }

        public int? RatingStandard { get; set; }

        [Key]
        [StringLength(10)]
        public string AgeGroup { get; set; }
    }
}
