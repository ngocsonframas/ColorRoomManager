namespace ColorRoomManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MixingOut")]
    public partial class MixingOut
    {
        public int Id { get; set; }

        public double? WeightRunner { get; set; }

        public double? WeightDefect { get; set; }

        public double? WeightBlackDot { get; set; }

        public double? WeighContamination { get; set; }

        public double? WeightRecycle { get; set; }

        public double? WeightCookie { get; set; }

        public int? MixRawId { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
