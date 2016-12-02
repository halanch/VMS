namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Accomodation")]
    public partial class Accomodation
    {
        public long AccomodationID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(100)]
        public string Latitude { get; set; }

        [StringLength(100)]
        public string Longitude { get; set; }

        public int TotalRooms { get; set; }

        public int TotalBeds { get; set; }

        public int isAvailable { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdate { get; set; }
    }
}
