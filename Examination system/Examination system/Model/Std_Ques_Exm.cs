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
    
    public partial class Std_Ques_Exm
    {
        public int Std_Id { get; set; }
        public int Exm_Id { get; set; }
        public int Ques_Id { get; set; }
        public string Std_Answer { get; set; }
    
        public virtual Exam Exam { get; set; }
        public virtual Question Question { get; set; }
        public virtual Student Student { get; set; }
    }
}
