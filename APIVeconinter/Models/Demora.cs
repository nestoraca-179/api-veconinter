//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIVeconinter.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Demora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Demora()
        {
            this.DemoraContenedor = new HashSet<DemoraContenedor>();
        }
    
        public int IdDemora { get; set; }
        public System.DateTime FechaDemora { get; set; }
        public int ClienteDemora { get; set; }
        public int ClienteTercero { get; set; }
        public int TasaCambioDemora { get; set; }
        public int BLDemora { get; set; }
        public Nullable<double> SubtotalDemoraUSD { get; set; }
        public Nullable<double> SubTotalDemoraBS { get; set; }
        public Nullable<double> IVADemoraUSD { get; set; }
        public Nullable<double> IVADemoraBS { get; set; }
        public Nullable<double> TotalDemoraUSD { get; set; }
        public Nullable<double> TotalDemoraBS { get; set; }
        public string ObservacionesDemora { get; set; }
        public int UsuarioDemora { get; set; }
        public int TipoDemora { get; set; }
        public int EstatusDemora { get; set; }
    
        public virtual BLEmbarque BLEmbarque { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Cliente Cliente1 { get; set; }
        public virtual TasaCambio TasaCambio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DemoraContenedor> DemoraContenedor { get; set; }
    }
}
