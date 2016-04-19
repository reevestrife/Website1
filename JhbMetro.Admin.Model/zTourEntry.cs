namespace JhbMetro.Admin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class zTourEntry
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TourID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SectionID { get; set; }

        [StringLength(12)]
        public string ChessaID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(80)]
        public string PlayerName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(80)]
        public string PlayerSurname { get; set; }

        [Required]
        [StringLength(3)]
        public string PlayerUnion { get; set; }

        [StringLength(80)]
        public string PlayerClub { get; set; }

        [StringLength(80)]
        public string PlayerClubOther { get; set; }

        [StringLength(10)]
        public string PlayerGender { get; set; }

        [StringLength(10)]
        public string PlayerBirthdate { get; set; }

        [StringLength(20)]
        public string PlayerPhone { get; set; }

        [StringLength(80)]
        public string PlayerEmail { get; set; }

        [StringLength(10)]
        public string Payment { get; set; }

        [StringLength(150)]
        public string PaymentNotes { get; set; }

        [StringLength(10)]
        public string RegisterDate { get; set; }

        [StringLength(10)]
        public string PaymentDate { get; set; }

        [StringLength(5)]
        public string PaymentProofReceived { get; set; }

        [StringLength(5)]
        public string entryOK { get; set; }

        [StringLength(80)]
        public string entryComments { get; set; }
    }
}
