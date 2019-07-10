namespace Nakliye.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Taşımalar
    {
        [Key]
        public int TaşımaID { get; set; }

        public int MusteriID { get; set; }

        public int NakliyeciID { get; set; }

        public int AdresID { get; set; }

        public DateTime TaşımaTarihi { get; set; }

        public virtual Adresler Adresler { get; set; }

        public virtual Musteriler Musteriler { get; set; }

        public virtual Nakliyeciler Nakliyeciler { get; set; }
    }
}
