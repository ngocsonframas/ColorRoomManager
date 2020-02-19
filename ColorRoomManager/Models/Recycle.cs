namespace ColorRoomManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recycle")]
    public partial class Recycle
    {
        [Key]
        [StringLength(50)]
        public string RecycleCode { get; set; }

        [StringLength(150)]
        public string RecyclingName { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? MixRawId { get; set; }

        public double? WeightRecycled { get; set; }
    }
}
