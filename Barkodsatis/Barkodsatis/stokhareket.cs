//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Barkodsatis
{
    using System;
    using System.Collections.Generic;
    
    public partial class stokhareket
    {
        public int id { get; set; }
        public string barkod { get; set; }
        public string urunadi { get; set; }
        public string birim { get; set; }
        public Nullable<double> miktar { get; set; }
        public string urungrup { get; set; }
        public string kullanici { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
    }
}