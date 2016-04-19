namespace JhbMetro.Admin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class zUnion
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string UnionCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(80)]
        public string UnionName { get; set; }

        [StringLength(80)]
        public string UnionContactPerson { get; set; }

        [StringLength(15)]
        public string UnionContactPhone { get; set; }

        [StringLength(80)]
        public string UnionContactEmail { get; set; }

        [StringLength(80)]
        public string UnionWeb { get; set; }
    }
}
