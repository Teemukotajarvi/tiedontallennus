//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tunnit
    {
        public int Tunti_id { get; set; }
        public Nullable<int> Projekti_id { get; set; }
        public Nullable<int> Henkilo_id { get; set; }
        public Nullable<System.DateTime> Pvm { get; set; }
        public Nullable<int> Tunnit1 { get; set; }
    
        public virtual Henkilot Henkilot { get; set; }
        public virtual Projektit Projektit { get; set; }
    }
}
