using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.DA.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRM.DA.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<PersonStage> PersonStages { get; set; }
        public DbSet<Avatar> Avatars { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PersonStage>().HasKey(x => new { x.PersonId, x.StageId});
        }
    }
}
