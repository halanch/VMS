namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegionCommittee")]
    public partial class RegionCommittee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegionCommittee()
        {
            CommitteeVolunteers = new HashSet<CommitteeVolunteer>();
        }

        public long RegionCommitteeID { get; set; }

        public long? CommitteeID { get; set; }

        public long? SubCommitteeID { get; set; }

        public long? HajjSessionID { get; set; }

        public int Active { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdate { get; set; }

        public virtual Committee Committee { get; set; }

        public virtual HajjSession HajjSession { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommitteeVolunteer> CommitteeVolunteers { get; set; }

        public virtual SubCommittee SubCommittee { get; set; }
    }
}
