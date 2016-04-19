namespace JhbMetro.Admin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tvTourReady_Sel
    {
        [Key]
        [Column(Order = 0)]
        public int TourID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TourName { get; set; }

        [StringLength(250)]
        public string TourDescription { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string TourOrganiserClub { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime TourStartDate { get; set; }
    }
}
