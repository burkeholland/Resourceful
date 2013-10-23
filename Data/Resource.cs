//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resourceful.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Resource
    {
        public Resource()
        {
            this.Schedules = new HashSet<Schedule>();
        }
    
        public int ResourceID { get; set; }
        public string ResourceName { get; set; }
        public Nullable<int> ResourceTypeID { get; set; }
        public string Comments { get; set; }
    
        public virtual ResourceType ResourceType { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
