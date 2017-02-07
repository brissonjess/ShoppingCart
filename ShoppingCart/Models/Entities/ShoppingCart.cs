namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShoppingCart")]
    public partial class ShoppingCart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShoppingCart()
        {
            ShoppingCart_item = new HashSet<ShoppingCart_item>();
        }

        [Key]
        public int shoppingCart_id { get; set; }

        public DateTime? cart_created { get; set; }

        public DateTime? cart_updated { get; set; }

        [StringLength(128)]
        public string user_id { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCart_item> ShoppingCart_item { get; set; }
    }
}
