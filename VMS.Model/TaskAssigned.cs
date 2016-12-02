namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskAssigned")]
    public partial class TaskAssigned
    {
        public long TaskAssignedID { get; set; }

        public long? AssignedToCommitteeVolunteerID { get; set; }

        public long? AssignedToTeamID { get; set; }

        public long? AssignedBy { get; set; }

        public long? TaskStatusID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateFinish { get; set; }

        public long? WorkerTypeID { get; set; }

        public long? TaskID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdate { get; set; }

        public virtual Task Task { get; set; }

        public virtual Volunteer Volunteer { get; set; }

        public virtual Team Team { get; set; }

        public virtual Volunteer Volunteer1 { get; set; }

        public virtual TaskStatu TaskStatu { get; set; }

        public virtual WorkerType WorkerType { get; set; }
    }
}
