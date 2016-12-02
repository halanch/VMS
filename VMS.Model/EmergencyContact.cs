namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmergencyContact")]
    public partial class EmergencyContact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmergencyContact()
        {
            VolunteerEmergencyContacts = new HashSet<VolunteerEmergencyContact>();
        }

        public long EmergencyContactID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Relation { get; set; }

        [Required]
        [StringLength(20)]
        public string MobileNo { get; set; }

        [StringLength(20)]
        public string PhoneNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerEmergencyContact> VolunteerEmergencyContacts { get; set; }
    }
}
