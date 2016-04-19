namespace JhbMetro.Admin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class zClub
    {
        [Key]
        [Column(Order = 0)]
        public int ClubID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string ClubUnion { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(150)]
        public string ClubName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string ClubShort { get; set; }

        [StringLength(80)]
        public string ClubContactPerson { get; set; }

        [StringLength(15)]
        public string ClubContactPhone { get; set; }

        [StringLength(80)]
        public string ClubContactEmail { get; set; }

        [StringLength(80)]
        public string ClubContactWeb { get; set; }

        [StringLength(80)]
        public string ClubLocation { get; set; }

        public int? ClubNumbers { get; set; }

        [StringLength(5)]
        public string ClubJMCStatus { get; set; }
    }
}
