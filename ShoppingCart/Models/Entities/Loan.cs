namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Loan")]
    public partial class Loan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Loan()
        {
            Loan_Detail = new HashSet<Loan_Detail>();
        }

        [Key]
        public int loan_id { get; set; }

        public DateTime? date_loaned { get; set; }

        public DateTime? date_due { get; set; }

        public DateTime? date_return { get; set; }

        [StringLength(128)]
        public string user_id { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loan_Detail> Loan_Detail { get; set; }
    }
}
