//using System.Web.Mvc;
namespace ColorRoomManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductColor")]
    public partial class ProductColor
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        [StringLength(50)]
        public string ColorCode { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        public bool? IsActive { get; set; }
        
    }
}
