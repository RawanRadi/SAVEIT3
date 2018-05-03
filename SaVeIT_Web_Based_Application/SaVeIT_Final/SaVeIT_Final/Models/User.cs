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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.SeniorProjects = new HashSet<SeniorProject>();
            this.SupAOIs = new HashSet<SupAOI>();
        }
    
        public string userId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public Nullable<int> userRole { get; set; }
        public string password { get; set; }
        public Nullable<int> projectGroup { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeniorProject> SeniorProjects { get; set; }
        public virtual SeniorProject SeniorProject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupAOI> SupAOIs { get; set; }
        public virtual UserRole UserRole1 { get; set; }
    }
}
