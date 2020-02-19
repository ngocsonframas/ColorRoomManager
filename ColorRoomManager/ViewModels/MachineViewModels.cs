using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColorRoomManager.ViewModels
{
    public class MachineViewModels
    {
        public int Id { get; set; }

        public string MachineName { get; set; }

        public string CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        public bool? IsActive { get; set; }
    }
}