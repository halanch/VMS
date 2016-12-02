namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IqamaDetail")]
    public partial class IqamaDetail
    {
        [Key]
        [StringLength(15)]
        public string IqamaNo { get; set; }

        [StringLength(200)]
        public string ArabicName { get; set; }

        [Required]
        [StringLength(50)]
        public string Profession { get; set; }

        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfExpiry { get; set; }

        [StringLength(200)]
        public string ImagePath { get; set; }

        public long? CountryID { get; set; }

        public long? VolunteerID { get; set; }

        public virtual Country Country { get; set; }

        public virtual Volunteer Volunteer { get; set; }
    }
}
