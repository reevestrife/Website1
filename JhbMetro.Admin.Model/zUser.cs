namespace JhbMetro.Admin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class zUser
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string UserAuth { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string UserLevel { get; set; }
    }
}
