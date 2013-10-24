using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resourceful.Repositories {
    public class ScheduleRepository {

        readonly Data.ScheduleEntities _entities = new Data.ScheduleEntities();

        public IEnumerable<Models.Schedule> All() {
            return _entities.Schedules.Select(s => new Models.Schedule {
                ScheduleID = s.ScheduleID,
                Resource = new Models.Resource {
                    Comments = s.Resource.Comments,
                    ResourceID = s.Resource.ResourceID,
                    ResourceName = s.Resource.ResourceName,
                    ResourceType = new Models.ResourceType {
                        ResourceTypeID = s.Resource.ResourceType.ResourceTypeID,
                        ResourceTypeName = s.Resource.ResourceName
                    }
                },
                ScheduleDate = s.ScheduleDate,
                ScheduleDetails = s.ScheduleDetails.Select(d => new Models.ScheduleDetail {
                    Confirmed = d.Confirmed,
                    Customer = new Models.Customer {
                       BillingAddress = d.Customer.BillingAddress,
                        City = d.Customer.City,
                        CompanyOrDepartment = d.Customer.CompanyOrDepartment,
                        ContactFirstName = d.Customer.ContactFirstName,
                        ContactLastName = d.Customer.ContactLastName,
                        ContactTitle = d.Customer.ContactTitle,
                        Country = d.Customer.Country,
                        CustomerID = d.Customer.CustomerID,
                        PhoneNumber = d.Customer.PhoneNumber,
                        PostalCode = d.Customer.PostalCode,
                        StateOrProvince = d.Customer.StateOrProvince
                    },
                    ScheduleDetailID = d.ScheduleDetailID,
                    ScheduleEndTime = d.ScheduleEndTime,
                    ScheduleID = s.ScheduleID,
                    ScheduleStartTime = d.ScheduleStartTime
                })
            });
        }
    }
}