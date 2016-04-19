namespace JhbMetro.Admin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class zMember
    {
        [Key]
        public int MemberID { get; set; }

        [Required]
        [StringLength(50)]
        public string MemberName { get; set; }

        [Required]
        [StringLength(50)]
        public string MemberSurname { get; set; }

        [StringLength(50)]
        public string MemberNamePref { get; set; }

        [Required]
        [StringLength(50)]
        public string MemberClub { get; set; }

        [StringLength(150)]
        public string MemberClubStatus { get; set; }

        [StringLength(12)]
        public string MemberChessaID { get; set; }

        [StringLength(10)]
        public string MemberGender { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MemberBirthdate { get; set; }

        [StringLength(10)]
        public string MemberEDP { get; set; }

        [StringLength(10)]
        public string MemberDIS { get; set; }

        [StringLength(20)]
        public string MemberPhone { get; set; }

        [StringLength(80)]
        public string MemberEmail { get; set; }

        [StringLength(80)]
        public string MemberParent { get; set; }

        [StringLength(20)]
        public string MemberParentPhone { get; set; }

        [StringLength(80)]
        public string MemberParentEmail { get; set; }

        [StringLength(80)]
        public string MemberParentEmployer { get; set; }

        [StringLength(10)]
        public string MemberPayment { get; set; }

        [StringLength(30)]
        public string MemberJMCStatus { get; set; }

        [StringLength(30)]
        public string MemberChessaStatus { get; set; }

        [StringLength(150)]
        public string MemberNotes { get; set; }

        [StringLength(1)]
        public string MemberActive { get; set; }
    }
}
