namespace ColorRoomManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(255)]
        public string ProductCode { get; set; }

        [StringLength(255)]
        public string ProductName { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
