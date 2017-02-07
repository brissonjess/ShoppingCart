namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            Equipment_Item_Details = new HashSet<Equipment_Item_Details>();
            Item_Order_Details = new HashSet<Item_Order_Details>();
            Loan_Detail = new HashSet<Loan_Detail>();
            ShoppingCart_item = new HashSet<ShoppingCart_item>();
        }

        [Key]
        public int item_id { get; set; }

        [StringLength(255)]
        public string item_name { get; set; }

        [StringLength(255)]
        public string item_descr { get; set; }

        public int? quantityOwned { get; set; }

        public int? quantityInstock { get; set; }

        public int? quantityLoaned { get; set; }

        public bool availableToLoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipment_Item_Details> Equipment_Item_Details { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item_Order_Details> Item_Order_Details { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loan_Detail> Loan_Detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCart_item> ShoppingCart_item { get; set; }
    }
}
