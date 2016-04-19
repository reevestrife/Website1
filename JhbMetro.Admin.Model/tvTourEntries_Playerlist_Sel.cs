namespace JhbMetro.Admin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tvTourEntries_Playerlist_Sel
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TourID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TourName { get; set; }

        [StringLength(50)]
        public string Section { get; set; }

        [StringLength(12)]
        public string ChessaID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(80)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(80)]
        public string Surname { get; set; }

        public int? Rating { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string Union { get; set; }

        [StringLength(80)]
        public string Club { get; set; }

        [StringLength(80)]
        public string ClubOther { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(10)]
        public string DOB { get; set; }

        [StringLength(10)]
        public string Payment { get; set; }

        [StringLength(10)]
        public string EntryReceived { get; set; }

        [StringLength(5)]
        public string EntryStatus { get; set; }

        [StringLength(80)]
        public string EntryComments { get; set; }
    }
}
