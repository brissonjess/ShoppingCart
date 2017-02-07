namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item_Order_Details
    {
        [Key]
        public int item_order_id { get; set; }

        public int? quantity_received { get; set; }

        public decimal? cost { get; set; }

        public int? item_id { get; set; }

        public int? order_id { get; set; }

        public virtual Item Item { get; set; }

        public virtual Order Order { get; set; }
    }
}
