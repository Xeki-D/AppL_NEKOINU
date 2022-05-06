namespace WpfApp_NEKOINU.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nekoinu_bdd.acheter")]
    public partial class acheter
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ID_PRODUIT { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ID_COMMANDE { get; set; }

        public short? QTE_COMMANDER { get; set; }

        public double? PRIX_TOTAL { get; set; }

        public virtual produit produit { get; set; }

        public virtual commande commande { get; set; }
    }
}
