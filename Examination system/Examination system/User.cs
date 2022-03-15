namespace Examination_system
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Instructors = new HashSet<Instructor>();
            Students = new HashSet<Student>();
        }

        [Key]
        public int U_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string U_UserName { get; set; }

        [StringLength(50)]
        public string U_Email { get; set; }

        [Required]
        [StringLength(50)]
        public string U_Password { get; set; }

        [StringLength(1)]
        public string U_Sex { get; set; }

        public bool U_IsStd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instructor> Instructors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
