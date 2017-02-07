namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Medium
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medium()
        {
            Media_Comment = new HashSet<Media_Comment>();
        }

        [Key]
        public int media_id { get; set; }

        public DateTime? date_upload { get; set; }

        [StringLength(255)]
        public string fileUrl { get; set; }

        [StringLength(255)]
        public string credit { get; set; }

        [StringLength(255)]
        public string media_title { get; set; }

        [StringLength(255)]
        public string media_alt_title { get; set; }

        [StringLength(255)]
        public string media_descr { get; set; }

        public bool pub_access { get; set; }

        public DateTime? expiry_date { get; set; }

        [StringLength(1)]
        public string media_code { get; set; }

        [StringLength(1)]
        public string status_code { get; set; }

        public int? media_access_id { get; set; }

        [StringLength(128)]
        public string user_id { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual Media_Access Media_Access { get; set; }

        public virtual Media_Type Media_Type { get; set; }

        public virtual Status Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Media_Comment> Media_Comment { get; set; }
    }
}
