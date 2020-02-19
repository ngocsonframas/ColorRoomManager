using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColorRoomManager.ViewModels
{
    public class ColorViewModels
    {
        public string ColorCode { get; set; }

        public string ColorName { get; set; }

        public string ProductCode { get; set; }

        public bool? IsActive { get; set; }

        public string CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}