namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Team")]
    public partial class Team
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Team()
        {
            TaskAssigneds = new HashSet<TaskAssigned>();
        }

        public long TeamID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public long? HajjSessionID { get; set; }

        public int isActive { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdate { get; set; }

        public virtual HajjSession HajjSession { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskAssigned> TaskAssigneds { get; set; }
    }
}
