namespace Nakliye.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MusteriAdres
    {
        public int MusteriAdresID { get; set; }

        public int AdresID { get; set; }

        public int MusteriID { get; set; }

        public virtual Adresler Adresler { get; set; }

        public virtual Musteriler Musteriler { get; set; }
    }
}
