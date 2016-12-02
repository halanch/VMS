namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehicle")]
    public partial class Vehicle
    {
        public long VehicleID { get; set; }

        [Required]
        [StringLength(20)]
        public string RegistrationNo { get; set; }

        public long? OwnerID { get; set; }

        [Required]
        [StringLength(100)]
        public string DriverName { get; set; }

        [Required]
        [StringLength(15)]
        public string DriverIqamaNo { get; set; }

        [Required]
        [StringLength(15)]
        public string DriverMobileNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateRegistrationEnd { get; set; }

        public int Capacity { get; set; }

        public long? VehicleTypeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdate { get; set; }

        public virtual Volunteer Volunteer { get; set; }

        public virtual VehicleType VehicleType { get; set; }
    }
}
