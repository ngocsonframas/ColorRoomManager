namespace ColorRoomManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Step")]
    public partial class Step
    {
        [Key]
        [StringLength(50)]
        public string StepCode { get; set; }

        [StringLength(150)]
        public string StepName { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
