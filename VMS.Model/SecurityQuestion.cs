namespace VMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SecurityQuestion")]
    public partial class SecurityQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SecurityQuestion()
        {
            VolunteerSecurityQuestions = new HashSet<VolunteerSecurityQuestion>();
        }

        [Key]
        public long QuestionID { get; set; }

        [Required]
        [StringLength(200)]
        public string Question { get; set; }

        public int isDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerSecurityQuestion> VolunteerSecurityQuestions { get; set; }
    }
}
