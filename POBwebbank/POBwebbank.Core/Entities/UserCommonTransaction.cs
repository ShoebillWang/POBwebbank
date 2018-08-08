namespace POBwebbank.Core {
    using Abp.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserCommonTransaction : Entity<Guid> {
        public Guid Id { get; set; }

        public int UserId { get; set; }

        public int TransactionId { get; set; }

        public int SetOrder { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
