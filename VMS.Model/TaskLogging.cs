namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskLogging")]
    public partial class TaskLogging
    {
        public long TaskLoggingID { get; set; }

        public long? TaskID { get; set; }

        public long? TaskAssignedID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateEnd { get; set; }

        public DateTime? TimeStart { get; set; }

        public DateTime? TimeEnd { get; set; }

        public long? TaskStatusID { get; set; }

        public long? WorkerTypeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInsert { get; set; }

        public long? UserID { get; set; }
    }
}
