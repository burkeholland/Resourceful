using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resourceful.Models {
    public class Reservation : ISchedulerEvent {
        public string Description { get; set; }
        public DateTime End { get; set; }
        public bool IsAllDay { get; set; }
        public string RecurrenceException { get; set; }
        public string RecurrenceRule { get; set; }
        public DateTime Start { get; set; }
        public string Title { get; set; }
        public int ResourceID { get; set; }
        public int ReservationID { get; set; }
    }
}