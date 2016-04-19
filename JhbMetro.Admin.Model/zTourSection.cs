namespace JhbMetro.Admin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class zTourSection
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TourID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int SectionID { get; set; }

        [StringLength(50)]
        public string SectionName { get; set; }

        public int? SectionMinRating { get; set; }

        public int? SectionMaxRating { get; set; }

        public int? SectionOldestYear { get; set; }

        [StringLength(5)]
        public string SectionAllowUnRated { get; set; }

        [StringLength(5)]
        public string SectionAllowPlayUp { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SectionStartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SectionEndDate { get; set; }

        public int? SectionCostOnline { get; set; }

        public int? SectionCostVenue { get; set; }
    }
}
