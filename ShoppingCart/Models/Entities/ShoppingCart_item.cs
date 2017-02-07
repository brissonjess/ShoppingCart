namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ShoppingCart_item
    {
        [Key]
        public int shoppingCartItem_id { get; set; }

        public int? shoppingCart_id { get; set; }

        public int? item_id { get; set; }

        public int? quantity { get; set; }

        public virtual Item Item { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
