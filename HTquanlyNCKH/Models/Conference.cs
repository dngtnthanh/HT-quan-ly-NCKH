//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HTquanlyNCKH.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conference
    {
        public int conferenceID { get; set; }
        public string cfrName { get; set; }
        public string cfrDescription { get; set; }
        public Nullable<System.DateTime> cfrCreateDate { get; set; }
        public Nullable<System.DateTime> cfrModifierDate { get; set; }
        public Nullable<int> cfrCreateUser { get; set; }
        public Nullable<int> cfrModifierUser { get; set; }
    }
}
