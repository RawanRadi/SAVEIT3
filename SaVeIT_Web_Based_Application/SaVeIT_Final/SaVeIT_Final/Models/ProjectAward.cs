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
    
    public partial class ProjectAward
    {
        public int Id { get; set; }
        public int AwardId { get; set; }
        public int ProjectId { get; set; }
    
        public virtual Award Award { get; set; }
        public virtual SeniorProject SeniorProject { get; set; }
    }
}
