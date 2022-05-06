namespace WpfApp_NEKOINU.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nekoinu_bdd.produit")]
    public partial class produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produit()
        {
            acheter = new HashSet<acheter>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ID_PRODUIT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(32)]
        public string NOM_PRODUIT { get; set; }

        public double PRIX_PRODUIT { get; set; }

        public int STOCK_PRODUIT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string DESC_PRODUIT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string IMG_PRODUIT { get; set; }

        public int? ANIMAL_PRODUIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acheter> acheter { get; set; }
    }
}
