namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BlackList")]
    public partial class BlackList
    {
        public long BlackListID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateBlackList { get; set; }

        public long BlackListedBy { get; set; }

        [Required]
        [StringLength(200)]
        public string Reason { get; set; }

        public long? VolunteerID { get; set; }

        public int isDeleted { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdate { get; set; }

        public virtual Volunteer Volunteer { get; set; }
    }
}
