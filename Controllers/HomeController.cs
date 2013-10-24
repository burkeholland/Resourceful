using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resourceful.Controllers
{
    public class HomeController : Controller
    {
        readonly Repositories.ResourceRepository _resourceRepository = new Repositories.ResourceRepository();
        readonly Repositories.ResourceTypeRepository _resourceTypeRepository = new Repositories.ResourceTypeRepository();

        public ActionResult Index()
        {
            // query the database for all resources
            var resources = _resourceRepository.All();

            // push the first item in the resources collection ResourceType as the default
            ViewBag.DefaultResourceType = _resourceTypeRepository.All().FirstOrDefault();

            ViewBag.Tab = "resources";

            // pass the resources to the view as the model
            return View(resources);
        }
    }
}
