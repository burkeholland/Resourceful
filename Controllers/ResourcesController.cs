using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resourceful.Controllers
{
    public class ResourcesController : Controller
    {
        readonly Repositories.ResourceRepository _resourceRepo = new Repositories.ResourceRepository();

        public ActionResult Index() {

            var resources = _resourceRepo.All();

            return Json(resources, JsonRequestBehavior.AllowGet);
        
        }

        public ActionResult Update([DataSourceRequest] DataSourceRequest request, Models.Resource resource) {
            if (resource != null && ModelState.IsValid) {
                _resourceRepo.Update(resource);
            }

            return Json(new[] { resource }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Create([DataSourceRequest] DataSourceRequest request, Models.Resource resource) {

            if (resource != null && ModelState.IsValid) {
                resource.ResourceID = _resourceRepo.Create(resource);
            }

            return Json(new[] { resource }.ToDataSourceResult(request, ModelState));
        }
    }
}
