//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieTickets.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hall
    {
        public int Id { get; set; }
        public int CinemaId { get; set; }
        public string Description { get; set; }
        public string Schema { get; set; }
        public Nullable<double> VipCoef { get; set; }
    
        public virtual Cinema Cinema { get; set; }
    }
}
