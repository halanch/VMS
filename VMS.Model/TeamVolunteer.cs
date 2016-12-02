namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeamVolunteer")]
    public partial class TeamVolunteer
    {
        [Key]
        public long TeamID { get; set; }

        public long? VolunteerID { get; set; }

        public long? RoleID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdate { get; set; }

        public virtual Role Role { get; set; }

        public virtual Volunteer Volunteer { get; set; }
    }
}
