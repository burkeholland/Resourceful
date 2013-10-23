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
        readonly Repositories.ResourceRepository _resourceRepository = new Repositories.ResourceRepository();

        public ActionResult Update([DataSourceRequest] DataSourceRequest request, Models.Resource resource) {
            if (resource != null && ModelState.IsValid) {
                _resourceRepository.Update(resource);
            }

            return Json(new[] { resource }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Create([DataSourceRequest] DataSourceRequest request, Models.Resource resource) {

            if (resource != null && ModelState.IsValid) {
                resource.ResourceID = _resourceRepository.Create(resource);
            }

            return Json(new[] { resource }.ToDataSourceResult(request, ModelState));
        }
    }
}
