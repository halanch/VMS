namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VolunteerTraining")]
    public partial class VolunteerTraining
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long VolunteerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TrainingOfferedID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInsert { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdate { get; set; }

        public virtual TrainingOffered TrainingOffered { get; set; }

        public virtual Volunteer Volunteer { get; set; }
    }
}
