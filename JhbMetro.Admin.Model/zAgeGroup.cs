namespace JhbMetro.Admin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class zAgeGroup
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string AgeGroup { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string BirthYear { get; set; }
    }
}
