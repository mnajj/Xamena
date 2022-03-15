namespace Examination_system
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Choice")]
    public partial class Choice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Choice()
        {
            Questions = new HashSet<Question>();
        }

        [Key]
        public int Cho_Id { get; set; }

        public int? Ques_Id { get; set; }

        [StringLength(100)]
        public string Cho_Content { get; set; }

        [StringLength(1)]
        public string Cho_Char { get; set; }

        public virtual Question Question { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}
