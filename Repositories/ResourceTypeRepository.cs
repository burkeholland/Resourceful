using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resourceful.Repositories {
    public class ResourceTypeRepository {

        readonly Data.ScheduleEntities _entities = new Data.ScheduleEntities();

        public IQueryable<Models.ResourceType> All() {
            return _entities.ResourceTypes.Select(rt => new Models.ResourceType {
                ResourceTypeID = rt.ResourceTypeID,
                ResourceTypeName = rt.ResourceType1
            });
        }

    }
}