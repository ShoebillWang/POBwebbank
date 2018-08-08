namespace POBwebbank.Core {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Abp.EntityFramework;

    public partial class POBwebbankModel : AbpDbContext {
        public POBwebbankModel()
            : base("name=POBwebbankModel") {
        }

        public virtual DbSet<TransactionTypy> TransactionTypies { get; set; }
        public virtual DbSet<UserCommonTransaction> UserCommonTransactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}
