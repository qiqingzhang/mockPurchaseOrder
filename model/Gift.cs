namespace MopckPurchaseOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gift")]
    public partial class Gift
    {
        public int Id { get; set; }

        public int GoodsId { get; set; }

        public int Point { get; set; }

        public int MaxNum { get; set; }

        public int IsValid { get; set; }

        [StringLength(50)]
        public string GiftName { get; set; }

        public DateTime UpdateTime { get; set; }

        public int UserId { get; set; }
    }
}
