namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrainingOffered")]
    public partial class TrainingOffered
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrainingOffered()
        {
            VolunteerTrainings = new HashSet<VolunteerTraining>();
        }

        public long TrainingOfferedID { get; set; }

        public long? TrainingID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateEnd { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(100)]
        public string Latitude { get; set; }

        [StringLength(100)]
        public string Longitude { get; set; }

        public long? RegionID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdate { get; set; }

        public virtual Region Region { get; set; }

        public virtual Training Training { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerTraining> VolunteerTrainings { get; set; }
    }
}
