using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resourceful.Repositories {
    public class ScheduleDetailRepository {

        readonly Data.ScheduleEntities _entities = new Data.ScheduleEntities();

        //public IQueryable<Models.ScheduleDetail> Where(Func<Data.ScheduleDetail, bool> where) {
        //    return _entities.ScheduleDetails.Where(where).Select(sd => new Models.ScheduleDetail {
        //    });
        //}
    
    }
}