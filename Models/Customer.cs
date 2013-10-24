using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resourceful.Models {
    public class Customer {
        public int CustomerID { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string CompanyOrDepartment { get; set; }
        public string BillingAddress { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string ContactTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string Extension { get; set; }
        public string FaxNumber { get; set; }
    }
}