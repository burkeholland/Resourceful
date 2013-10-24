using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resourceful.Models {
    public class ScheduleDetail {
        public int ScheduleDetailID { get; set; }
        public int ScheduleID { get; set; }
        public Models.Customer Customer { get; set; }
        public DateTime? ScheduleStartTime { get; set; }
        public DateTime? ScheduleEndTime { get; set; }
        public bool Confirmed { get; set; }
    }
}