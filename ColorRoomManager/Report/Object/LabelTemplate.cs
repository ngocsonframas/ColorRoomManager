using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColorRoomManager.Reports.Object
{
    public class LabelTemplate
    {
        public double? ColorCode { get; set; }
        public string ColorName { get; set; }
        public string MaterialName { get; set; }
        public double? ScaleWeight { get; set; }
        public string ProductName { get; set; }
        public string LabelName { get; set; }
        public string Barcode { get; set; }
        public string MachineInfo { get; set; }
    }
}