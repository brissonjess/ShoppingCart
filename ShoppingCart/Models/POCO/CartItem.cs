using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingCart.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ShoppingCart.Models.POCO
{
    public class CartItem
    {
        public int item_id { get; set; }

        public string item_name { get; set; }

        public string item_descr { get; set; }

        public int? quantityOwned { get; set; }

        public int? quantityInstock { get; set; }

        public int? quantityLoaned { get; set; }

        public bool availableToLoan { get; set; }

        public int CartQuantity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCart_item> ShoppingCart_item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }
    }
}