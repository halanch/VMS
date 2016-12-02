namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VolunteerSecurityQuestion")]
    public partial class VolunteerSecurityQuestion
    {
        public long? VolunteerID { get; set; }

        public long? QuestionID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(200)]
        public string Answer { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int isDeleted { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime DateUpdate { get; set; }

        public virtual SecurityQuestion SecurityQuestion { get; set; }

        public virtual Volunteer Volunteer { get; set; }
    }
}
