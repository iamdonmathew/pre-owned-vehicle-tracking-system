//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PreOwnedVehicle.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblcity
    {
        public tblcity()
        {
            this.tblregs = new HashSet<tblreg>();
            this.tblvehicleregs = new HashSet<tblvehiclereg>();
        }
    
        public int cityid { get; set; }
        public Nullable<int> districtid { get; set; }
        public string cityname { get; set; }
    
        public virtual tbldistrict tbldistrict { get; set; }
        public virtual ICollection<tblreg> tblregs { get; set; }
        public virtual ICollection<tblvehiclereg> tblvehicleregs { get; set; }
    }
}
