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
    
    public partial class Foreign
    {
        public int foreignID { get; set; }
        public string fgnName { get; set; }
        public string fgnDescription { get; set; }
        public Nullable<System.DateTime> fgnCreateDate { get; set; }
        public Nullable<System.DateTime> fgnModifierDate { get; set; }
        public Nullable<int> fgnCreateUser { get; set; }
        public Nullable<int> fgnModifierUser { get; set; }
    }
}
