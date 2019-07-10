namespace Nakliye.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Photo")]
    public partial class Photo
    {
        public int ID { get; set; }

        [Column("Photo", TypeName = "text")]
        public string Photo1 { get; set; }

        public int NakliyeciID { get; set; }

        public virtual Nakliyeciler Nakliyeciler { get; set; }
    }
}
