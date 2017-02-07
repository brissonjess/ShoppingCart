namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Equipment_Item_Details
    {
        [Key]
        public int item_details_id { get; set; }

        public DateTime? writeoff_date { get; set; }

        public bool? availableToLoan { get; set; }

        public int? item_id { get; set; }

        [StringLength(1)]
        public string status_code { get; set; }

        public int? kit_id { get; set; }

        public virtual Item Item { get; set; }

        public virtual Equipment_Kit Equipment_Kit { get; set; }

        public virtual Status Status { get; set; }
    }
}
