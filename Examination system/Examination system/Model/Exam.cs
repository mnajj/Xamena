//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examination_system.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exam()
        {
            this.Exm_Ques = new HashSet<Exm_Ques>();
            this.Std_Ques_Exm = new HashSet<Std_Ques_Exm>();
        }
    
        public int Exm_Id { get; set; }
        public Nullable<int> Crs_Id { get; set; }
        public Nullable<int> Generator_Id { get; set; }
        public Nullable<int> Exm_Grade { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Instructor Instructor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exm_Ques> Exm_Ques { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Std_Ques_Exm> Std_Ques_Exm { get; set; }
    }
}