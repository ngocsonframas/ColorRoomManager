namespace ColorRoomManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Color")]
    public partial class Color
    {
        [Key]
        [StringLength(50)]
        public string ColorCode { get; set; }

        [StringLength(255)]
        public string ColorName { get; set; }

        [StringLength(255)]
        public string ProductCode { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
