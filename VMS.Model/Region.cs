namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Region")]
    public partial class Region
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Region()
        {
            TrainingOffereds = new HashSet<TrainingOffered>();
            Volunteers = new HashSet<Volunteer>();
        }

        public long RegionID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public long? CountryID { get; set; }

        public int isDeleted { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateInsert { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdate { get; set; }

        public virtual Country Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrainingOffered> TrainingOffereds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Volunteer> Volunteers { get; set; }
    }
}
