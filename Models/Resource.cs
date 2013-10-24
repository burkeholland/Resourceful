using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Resourceful.Models {
    public class Resource {
        
        public int ResourceID { get; set; }

        [Required(ErrorMessage="Resource Name Is Required")]
        public string ResourceName { get; set; }
        
        public string Comments { get; set; }

        [UIHint("ResourceType")]
        public ResourceType ResourceType { get; set; }

        [UIHint("ResourceColor")]
        public string Color { get; set; }
    }
}