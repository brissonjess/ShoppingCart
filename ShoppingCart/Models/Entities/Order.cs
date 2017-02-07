namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Item_Order_Details = new HashSet<Item_Order_Details>();
        }

        [Key]
        public int order_id { get; set; }

        public DateTime? receivedOn { get; set; }

        [StringLength(255)]
        public string username { get; set; }

        public decimal? subtotal { get; set; }

        public decimal? gst { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item_Order_Details> Item_Order_Details { get; set; }
    }
}
