using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resourceful.Models {
    public class Map {
        
        public static Models.Customer Customer(Data.Customer customer) {
            return new Models.Customer {
                BillingAddress = customer.BillingAddress,
                City = customer.City,
                CompanyOrDepartment = customer.CompanyOrDepartment,
                ContactFirstName = customer.ContactFirstName,
                ContactLastName = customer.ContactLastName,
                ContactTitle = customer.ContactTitle,
                Country = customer.Country,
                CustomerID = customer.CustomerID,
                Extension = customer.Extension,
                FaxNumber = customer.FaxNumber,
                PhoneNumber = customer.PhoneNumber,
                PostalCode = customer.PostalCode,
                StateOrProvince = customer.StateOrProvince
            };
        }

        public static Models.Resource Resource(Data.Resource resource) {
            return new Models.Resource {
                ResourceID = resource.ResourceID,
                ResourceName = resource.ResourceName,
                Comments = resource.Comments,
            };
        }

        public static IEnumerable<Models.Reservation> Reservation(Models.Schedule schedule) {

            var reservations = new List<Models.Reservation>();

            var date = (DateTime)schedule.ScheduleDate;

            foreach (var detail in schedule.ScheduleDetails) {

                var scheduleStartTime = (DateTime)detail.ScheduleStartTime;
                var startTime = new TimeSpan(scheduleStartTime.Hour, scheduleStartTime.Minute, scheduleStartTime.Second);

                var scheduleEndTime = (DateTime)detail.ScheduleEndTime;
                var endTime = new TimeSpan(scheduleEndTime.Hour, scheduleEndTime.Minute, scheduleEndTime.Second);

                var name = detail.Customer.ContactFirstName + " " + detail.Customer.ContactLastName;

                reservations.Add(new Models.Reservation {
                    IsAllDay = false,

                    // the start time and end time hold only the time.
                    Start = date + startTime,
                    End = date + endTime,

                    Title = name,

                    ResourceID = schedule.Resource.ResourceID,
                    ReservationID = detail.ScheduleDetailID

                });
            }

            return reservations;
        }

    }
}