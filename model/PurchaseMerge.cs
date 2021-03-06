namespace MopckPurchaseOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseMerge")]
    public partial class PurchaseMerge
    {
        public int Id { get; set; }

        public int FinalPurchaseId { get; set; }

        public int NeedToPurchaseId { get; set; }

        public int PurchaseId { get; set; }

        public int GoodsId { get; set; }

        public int Num { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
