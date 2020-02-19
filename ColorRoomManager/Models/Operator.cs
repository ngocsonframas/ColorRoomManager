namespace ColorRoomManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Operator")]
    public partial class Operator
    {
        [Key]
        [StringLength(20)]
        public string OperatorCode { get; set; }

        [StringLength(100)]
        public string OperatorName { get; set; }

        [StringLength(150)]
        public string Department { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
