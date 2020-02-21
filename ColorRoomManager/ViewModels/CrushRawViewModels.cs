using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColorRoomManager.ViewModels
{
    public class CrushRawViewModels
    {
        public int CrushRawId { get; set; }

        public string ShiftName { get; set; }

        public string OperatorName { get; set; }

        public string ProductName { get; set; }

        public string MaterialName { get; set; }

        public string ColorName { get; set; }

        public string StepName { get; set; }

        public double? WeightMix { get; set; }

        public double? WeightRecycle { get; set; }

        public int? MixRawId { get; set; }

        public double? WeightMaterial { get; set; }

        public double? TotalMaterial { get; set; }

        public string MachineName { get; set; }

        public string MixBacode { get; set; }

        public string CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}