namespace WpfApp_NEKOINU.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nekoinu_bdd.commande")]
    public partial class commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public commande()
        {
            acheter = new HashSet<acheter>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ID_COMMANDE { get; set; }

        public short ID_CLIENT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_COMMANDE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acheter> acheter { get; set; }

        public virtual client client { get; set; }
    }
}
