//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace server_api
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.DeviceGroups = new HashSet<DeviceGroup>();
            this.Devices = new HashSet<Device>();
        }
    
        public string Email { get; set; }
        public string Pass { get; set; }
    
        public virtual ICollection<DeviceGroup> DeviceGroups { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
    }
}