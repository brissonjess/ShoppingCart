namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sponsor_Event
    {
        [Key]
        public int sponsor_event_id { get; set; }

        [Column(TypeName = "text")]
        public string event_descr { get; set; }

        public DateTime? event_start_time { get; set; }

        [StringLength(255)]
        public string event_url { get; set; }

        [StringLength(255)]
        public string location { get; set; }

        [StringLength(128)]
        public string user_id { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
    }
}
