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
    
    public partial class Pollutant
    {
        public Pollutant()
        {
            this.DataPoints = new HashSet<DataPoint>();
        }
    
        public string PollutantName { get; set; }
    
        public virtual ICollection<DataPoint> DataPoints { get; set; }
    }
}