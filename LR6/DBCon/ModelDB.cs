using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LR6.DBCon
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>()
                .Property(e => e.StartedAt)
                .HasPrecision(6);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.User)
                .WithOptional(e => e.Event)
                .WillCascadeOnDelete();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Activity)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.ModeratorID);
        }
    }
}
