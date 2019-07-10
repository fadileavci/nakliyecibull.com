namespace Nakliye.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Adresler")]
    public partial class Adresler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adresler()
        {
            Taşımalar = new HashSet<Taşımalar>();
            MusteriAdres = new HashSet<MusteriAdres>();
        }

        [Key]
        public int AdresID { get; set; }

        [StringLength(50)]
        public string Adresİli { get; set; }

        [StringLength(50)]
        public string Adresİlce { get; set; }

        public int? AdresPostaKodu { get; set; }

        [StringLength(150)]
        public string AdresDetay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taşımalar> Taşımalar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusteriAdres> MusteriAdres { get; set; }
    }
}
