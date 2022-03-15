namespace Examination_system
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exam")]
    public partial class Exam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exam()
        {
            Questions = new HashSet<Question>();
        }

        [Key]
        public int Exm_Id { get; set; }

        public int? Crs_Id { get; set; }

        public int? Generator_Id { get; set; }

        public int? Exm_Grade { get; set; }

        public virtual Course Course { get; set; }

        public virtual Instructor Instructor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}
