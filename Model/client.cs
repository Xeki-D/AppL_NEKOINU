namespace WpfApp_NEKOINU.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nekoinu_bdd.client")]
    public partial class client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public client()
        {
            commande = new HashSet<commande>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ID_CLIENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(32)]
        public string NOM_CLIENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(32)]
        public string PRENOM_CLIENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(32)]
        public string MDP_CLIENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(32)]
        public string ADR_CLIENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(32)]
        public string VILLE_CLIENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(32)]
        public string CP_CLIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commande> commande { get; set; }
    }
}
