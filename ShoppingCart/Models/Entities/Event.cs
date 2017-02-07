namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            Event_Members = new HashSet<Event_Members>();
        }

        [Key]
        public int event_id { get; set; }

        [StringLength(255)]
        public string event_title { get; set; }

        [Column(TypeName = "text")]
        public string event_descr { get; set; }

        [StringLength(255)]
        public string location { get; set; }

        public bool pub_access { get; set; }

        public DateTime? start_time { get; set; }

        public DateTime? end_time { get; set; }

        [StringLength(128)]
        public string user_id { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event_Members> Event_Members { get; set; }
    }
}
