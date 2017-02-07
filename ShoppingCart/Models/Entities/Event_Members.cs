namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Event_Members
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int event_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string user_id { get; set; }

        public bool? confirmed { get; set; }

        public int? event_role_id { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual Event Event { get; set; }

        public virtual Event_Roles Event_Roles { get; set; }
    }
}
