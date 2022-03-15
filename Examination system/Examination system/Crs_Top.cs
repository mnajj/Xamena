namespace Examination_system
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Crs_Top
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Crs_Id { get; set; }

        [Key]
        [Column("Crs_Top", Order = 1)]
        [StringLength(50)]
        public string Crs_Top1 { get; set; }

        public virtual Course Course { get; set; }
    }
}
