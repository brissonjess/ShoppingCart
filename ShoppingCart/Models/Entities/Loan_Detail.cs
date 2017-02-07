namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Loan_Detail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int item_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int loan_id { get; set; }

        public int? item_quantity { get; set; }

        public bool agreementOfCare { get; set; }

        [Column(TypeName = "text")]
        public string reason { get; set; }

        public virtual Item Item { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
