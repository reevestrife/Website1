namespace JhbMetro.Admin.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tvJMC_Members_List_Sel
    {
        [StringLength(120)]
        public string MemberName { get; set; }

        [StringLength(120)]
        public string MemberSurname { get; set; }

        [StringLength(50)]
        public string MemberNamePref { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MemberClub { get; set; }

        [StringLength(150)]
        public string MemberClubStatus { get; set; }

        [StringLength(20)]
        public string MemberChessaID { get; set; }

        [StringLength(10)]
        public string MemberGender { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MemberBirthdate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string AgeGroup { get; set; }

        [StringLength(30)]
        public string MemberJMCStatus { get; set; }

        [StringLength(10)]
        public string MemberPayment { get; set; }

        [StringLength(7)]
        public string ClubJMCStatus { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? last_played { get; set; }
    }
}
