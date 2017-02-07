namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Media_Comment
    {
        [Key]
        public int comment_id { get; set; }

        [Column(TypeName = "text")]
        public string comment { get; set; }

        public DateTime? comment_time { get; set; }

        public int? media_id { get; set; }

        [StringLength(128)]
        public string user_id { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual Medium Medium { get; set; }
    }
}
