//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaVeIT_Final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectsAOI
    {
        public int SPtId { get; set; }
        public int AOIId { get; set; }
        public int Id { get; set; }
    
        public virtual AreaOFInterest AreaOFInterest { get; set; }
        public virtual SeniorProject SeniorProject { get; set; }
    }
}