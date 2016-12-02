namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VolunteerLanguage")]
    public partial class VolunteerLanguage
    {
        public long? VolunteerID { get; set; }

        public long? LanguageID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string proficiency { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime DateUpdate { get; set; }

        public virtual Language Language { get; set; }

        public virtual Volunteer Volunteer { get; set; }
    }
}
