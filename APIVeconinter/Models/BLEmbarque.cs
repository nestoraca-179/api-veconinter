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
    
    public partial class BLEmbarque
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BLEmbarque()
        {
            this.Demora = new HashSet<Demora>();
            this.Preliquidacion = new HashSet<Preliquidacion>();
        }
    
        public int IdBLEmbarque { get; set; }
        public string NroBLEmbarque { get; set; }
        public int ItinerarioBLEmbarque { get; set; }
        public Nullable<int> DiasLibresBLEmbarque { get; set; }
    
        public virtual Itinerario Itinerario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Demora> Demora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Preliquidacion> Preliquidacion { get; set; }
    }
}