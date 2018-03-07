using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Slacker.Models
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("name=ApplicationContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataModel.FinancialTracker>()

                .HasKey(m => m.TransactionId)
                .Property(m => m.InputValue).IsRequired();

            modelBuilder.Entity<DataModel.FinancialTracker>()

                .Property(m => m.CurrentDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsRequired();

            modelBuilder.Entity<DataModel.FinancialTracker>()

                .Property(m => m.SpentGainedSource).IsRequired();

            modelBuilder.Entity<DataModel.FinancialTracker>()

                .Property(m => m.SpentGainedStatus);

            modelBuilder.Entity<DataModel.FinancialTracker>()

                .ToTable("FinancialTracker");


        }

        public DbSet<DataModel.FinancialTracker> FinancialTracker { get; set; }
    }
}
