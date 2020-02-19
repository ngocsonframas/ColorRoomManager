namespace ColorRoomManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Material
    {
        [Key]
        [StringLength(50)]
        public string MaterialCode { get; set; }

        [StringLength(255)]
        public string MaterialName { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
