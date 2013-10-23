using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resourceful.Controllers
{
    public class ResourceTypesController : Controller
    {
        readonly Repositories.ResourceTypeRepository _repository = new Repositories.ResourceTypeRepository();

        public ActionResult Index()
        {
            var resourceTypes = _repository.All();

            return this.Json(resourceTypes, JsonRequestBehavior.AllowGet);
        }

    }
}
