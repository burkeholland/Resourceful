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
    
    public partial class ResourceType
    {
        public ResourceType()
        {
            this.Resources = new HashSet<Resource>();
        }
    
        public int ResourceTypeID { get; set; }
        public string ResourceType1 { get; set; }
    
        public virtual ICollection<Resource> Resources { get; set; }
    }
}
