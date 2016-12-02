namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VolunteerEmergencyContact")]
    public partial class VolunteerEmergencyContact
    {
        public long? VolunteerID { get; set; }

        public long? EmergencyContactID { get; set; }

        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime DateUpdate { get; set; }

        public virtual EmergencyContact EmergencyContact { get; set; }

        public virtual Volunteer Volunteer { get; set; }
    }
}
