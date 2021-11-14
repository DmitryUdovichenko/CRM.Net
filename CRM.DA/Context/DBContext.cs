using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.DA.Entities;
using CRM.DA.Entities.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRM.DA.Context
{
    /// <summary>
    /// Database Context
    /// </summary>
    public class DBContext : IdentityDbContext<CrmUser, CrmRole, Guid>
    {
        
        public DbSet<Project> Projects { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<PersonStage> PersonStages { get; set; }
        public DbSet<Avatar> Avatars { get; set; }
        public DbSet<CrmUserProfile> CrmUserProfiles { get; set; }
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PersonStage>().HasKey(x => new { x.PersonId, x.StageId});
        }
    }
}
