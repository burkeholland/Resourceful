using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resourceful.Repositories {
    public class ResourceRepository {

        Data.ScheduleEntities _entities = new Data.ScheduleEntities();

        public IQueryable<Models.Resource> Get() {

            var resources = _entities.Resources.Select(r => new Models.Resource {
                ResourceID = r.ResourceID,
                ResourceName = r.ResourceName,
                ResourceType = new Models.ResourceType {
                    ResourceTypeID = r.ResourceType.ResourceTypeID,
                    ResourceTypeName = r.ResourceType.ResourceType1
                },
                Comments = r.Comments
            });

            return resources;

        }

        public Models.Resource One(Func<Models.Resource, bool> action) {
            return Get().Where(action).FirstOrDefault();
        }

        public void Update(Models.Resource resource) {

            var target = _entities.Resources.Where(p => p.ResourceID == resource.ResourceID).FirstOrDefault();

            if (target != null) {
                target.ResourceName = resource.ResourceName;
                target.Comments = resource.Comments;
                target.ResourceTypeID = resource.ResourceType.ResourceTypeID;

                _entities.SaveChanges();
            }
        }

        public int Create(Models.Resource resource) {

            var target = new Data.Resource {
                ResourceName = resource.ResourceName,
                Comments = resource.Comments,
                ResourceTypeID = resource.ResourceType.ResourceTypeID,
            };

            var result = _entities.Resources.Add(target);

            _entities.SaveChanges();

            return result.ResourceID;
        }

    }
}