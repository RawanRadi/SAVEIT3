﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AreaOFInterest> AreaOFInterests { get; set; }
        public virtual DbSet<Award> Awards { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<ProjectAward> ProjectAwards { get; set; }
        public virtual DbSet<ProjectsAOI> ProjectsAOIs { get; set; }
        public virtual DbSet<SeniorProject> SeniorProjects { get; set; }
        public virtual DbSet<Stu_Projects> Stu_Projects { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<SupAOI> SupAOIs { get; set; }
        public virtual DbSet<SupervisorRole> SupervisorRoles { get; set; }
        public virtual DbSet<Supervisor> Supervisors { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        [DbFunction("Entities", "udf_Str_Parse")]
        public virtual IQueryable<udf_Str_Parse_Result> udf_Str_Parse(string @string, string delimiter)
        {
            var stringParameter = @string != null ?
                new ObjectParameter("String", @string) :
                new ObjectParameter("String", typeof(string));
    
            var delimiterParameter = delimiter != null ?
                new ObjectParameter("Delimiter", delimiter) :
                new ObjectParameter("Delimiter", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_Str_Parse_Result>("[Entities].[udf_Str_Parse](@String, @Delimiter)", stringParameter, delimiterParameter);
        }
    }
}
