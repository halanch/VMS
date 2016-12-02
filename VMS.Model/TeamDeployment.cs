namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeamDeployment")]
    public partial class TeamDeployment
    {
        [Key]
        public long TeamID { get; set; }

        public long? DeploymentID { get; set; }

        public long? WorkHourID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdate { get; set; }

        public virtual Deployment Deployment { get; set; }

        public virtual WorkHour WorkHour { get; set; }
    }
}
