namespace Examination_system
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            Std_Crs = new HashSet<Std_Crs>();
        }

        [Key]
        public int Std_Id { get; set; }

        public int? U_Id { get; set; }

        public int? Dept_Id { get; set; }

        [StringLength(50)]
        public string Std_Fname { get; set; }

        [StringLength(50)]
        public string Std_Lname { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Std_BOD { get; set; }

        [StringLength(100)]
        public string Std_Address { get; set; }

        public virtual Department Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Std_Crs> Std_Crs { get; set; }

        public virtual User User { get; set; }
    }
}
