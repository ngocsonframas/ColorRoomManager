namespace ColorRoomManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MixRaw")]
    public partial class MixRaw
    {
        public int MixRawId { get; set; }

        [StringLength(50)]
        public string ShiftCode { get; set; }

        [StringLength(20)]
        public string OperatorCode { get; set; }

        [StringLength(255)]
        public string ProductCode { get; set; }

        [StringLength(50)]
        public string MaterialCode { get; set; }

        [StringLength(50)]
        public string ColorCode { get; set; }

        [StringLength(50)]
        public string StepCode { get; set; }

        public double? WeightMix { get; set; }

        public double? WeightMaterial { get; set; }

        public double? TotalMaterial { get; set; }

        [StringLength(100)]
        public string MachineName { get; set; }

        public string MixBacode { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        public double? WeightRunner { get; set; }

        public double? WeightDefect { get; set; }

        public double? WeightBlackDot { get; set; }

        public double? WeighContamination { get; set; }

        public double? WeightColor { get; set; }

        public double? WeightRecycle { get; set; }
    }
}
