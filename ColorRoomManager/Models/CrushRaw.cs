namespace ColorRoomManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CrushRaw")]
    public partial class CrushRaw
    {
        public int CrushRawId { get; set; }

        [StringLength(50)]
        public string ShiftName { get; set; }

        [StringLength(100)]
        public string OperatorName { get; set; }

        [StringLength(255)]
        public string ProductName { get; set; }

        [StringLength(255)]
        public string MaterialName { get; set; }

        [StringLength(255)]
        public string ColorName { get; set; }

        [StringLength(150)]
        public string StepName { get; set; }

          [StringLength(100)]
        public string LossTypeName { get; set; }

        public double? WeightMix { get; set; }

        public double? WeightRecycle { get; set; }

        public int? MixRawId { get; set; }

        public double? WeightMaterial { get; set; }

        public double? TotalMaterial { get; set; }

        [StringLength(100)]
        public string MachineName { get; set; }

        public string MixBacode { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
