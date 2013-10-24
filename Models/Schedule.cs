using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resourceful.Models {
    public class Schedule {
        public int ScheduleID { get; set; }
        public Models.Resource Resource { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public IEnumerable<ScheduleDetail> ScheduleDetails { get; set; }
    }
}