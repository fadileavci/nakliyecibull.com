namespace Nakliye.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nakliyeciler")]
    public partial class Nakliyeciler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nakliyeciler()
        {
            Taşımalar = new HashSet<Taşımalar>();
            Photo = new HashSet<Photo>();
        }

        [Key]
        public int NakliyeciID { get; set; }

        [Required]
        [StringLength(50)]
        public string NakliyeSirketininAdı { get; set; }

        [StringLength(25)]
        public string NakliyeciTelefon1 { get; set; }

        [StringLength(20)]
        public string NakliyeciSehir { get; set; }

        [StringLength(30)]
        public string NakliyeciSemt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taşımalar> Taşımalar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photo> Photo { get; set; }
    }
}
