namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CommitteeVolunteer")]
    public partial class CommitteeVolunteer
    {
        public long? VolunteerID { get; set; }

        public long? RegionCommitteeID { get; set; }

        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime DateAdd { get; set; }

        public long? RoleID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int isActive { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdate { get; set; }

        public virtual RegionCommittee RegionCommittee { get; set; }

        public virtual Role Role { get; set; }

        public virtual Volunteer Volunteer { get; set; }
    }
}
