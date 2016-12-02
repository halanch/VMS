namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Task")]
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            TaskAssigneds = new HashSet<TaskAssigned>();
        }

        public long TaskID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCreate { get; set; }

        public long? TaskPriorityID { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public long? CreatedBy { get; set; }

        public long? TaskStatusID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdate { get; set; }

        public virtual Volunteer Volunteer { get; set; }

        public virtual TaskPriority TaskPriority { get; set; }

        public virtual TaskStatu TaskStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskAssigned> TaskAssigneds { get; set; }
    }
}
