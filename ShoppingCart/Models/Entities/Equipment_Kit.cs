namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Equipment_Kit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipment_Kit()
        {
            Equipment_Item_Details = new HashSet<Equipment_Item_Details>();
        }

        [Key]
        public int kit_id { get; set; }

        public DateTime? writeoff_date { get; set; }

        public bool? availableToLoan { get; set; }

        [StringLength(1)]
        public string status_code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipment_Item_Details> Equipment_Item_Details { get; set; }

        public virtual Status Status { get; set; }
    }
}
