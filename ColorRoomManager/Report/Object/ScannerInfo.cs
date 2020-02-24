using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColorRoomManager.Reports.Object
{
    public class ScannerInfo
    {
        public string ColorName { get; set; }
        public string MaterialName { get; set; }
        public decimal ScaleWeight { get; set; }
        public DateTime ScaleDate { get; set; }

        public int CountLabel { get; set; }
        public string Machine { get; set; }
        public string Barcode { get; set; }
    }
}