namespace ColorRoomManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Label
    {
        public int LabelId { get; set; }

        [StringLength(50)]
        public string LabelCode { get; set; }

        public int? MixRawId { get; set; }

        [StringLength(50)]
        public string RecycleCode { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
