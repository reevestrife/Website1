namespace JhbMetro.Admin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class zTournament
    {
        [Key]
        public int TourID { get; set; }

        [Required]
        [StringLength(50)]
        public string TourName { get; set; }

        [StringLength(250)]
        public string TourDescription { get; set; }

        [Required]
        [StringLength(50)]
        public string TourOrganiserUnion { get; set; }

        [Required]
        [StringLength(50)]
        public string TourOrganiserClub { get; set; }

        [StringLength(50)]
        public string TourOrganiserContact { get; set; }

        [StringLength(50)]
        public string TourOrganiserEmail { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TourStartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TourEndDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TourEntryStartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TourCufOffDate { get; set; }

        [StringLength(50)]
        public string TourFormat { get; set; }

        [StringLength(10)]
        public string TourRated { get; set; }

        [StringLength(5)]
        public string TourEntriesJMC { get; set; }

        [StringLength(1)]
        public string TourEntriesActive { get; set; }
    }
}
