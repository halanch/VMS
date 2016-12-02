namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Deployment")]
    public partial class Deployment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Deployment()
        {
            TeamDeployments = new HashSet<TeamDeployment>();
        }

        public long DeploymentID { get; set; }

        [Required]
        [StringLength(100)]
        public string PostName { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        public double? Longitutde { get; set; }

        public double? Latitude { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamDeployment> TeamDeployments { get; set; }
    }
}
