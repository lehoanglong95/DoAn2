//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocationAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LocationInfo
    {
        public int ID { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string SubThoroughfare { get; set; }
        public string Thoroughfare { get; set; }
        public string PostalCode { get; set; }
        public string Locality { get; set; }
        public string AdministrativeArea { get; set; }
        public string Country { get; set; }
        public string Timestamp { get; set; }
        public string UserName { get; set; }
    }
}