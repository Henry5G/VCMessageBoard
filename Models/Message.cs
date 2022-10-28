namespace VCMessageBoard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message")]
    public partial class Message
    {
        public int MessageID { get; set; }

        [Required]
        [StringLength(10)]
        public string StudentNum { get; set; }

        [Column("Message")]
        [Required]
        public string Message1 { get; set; }

        public virtual Student Student { get; set; }
    }
}
