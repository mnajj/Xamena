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
    
    public partial class Crs_Top
    {
        public int Crs_Id { get; set; }
        public string Crs_Top1 { get; set; }
    
        public virtual Course Course { get; set; }
    }
}