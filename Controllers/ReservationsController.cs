using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resourceful.Controllers
{
    public class ReservationsController : Controller
    {
        readonly Repositories.ScheduleRepository _scheduleRepo = new Repositories.ScheduleRepository();

        public ActionResult Index()
        {
            ViewBag.Tab = "reservations";

            return View();
        }

        public ActionResult Get([DataSourceRequest] DataSourceRequest request) {

            var schedules = _scheduleRepo.All();

            var reservations = new List<Models.Reservation>();

            foreach (var schedule in schedules) {
                reservations.AddRange(Models.Map.Reservation(schedule));
            }

            return Json(reservations.ToDataSourceResult(request));
        }
    }
}
