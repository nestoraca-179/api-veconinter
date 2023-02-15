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
    
    public partial class Reserva
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reserva()
        {
            this.ReservaContenedor = new HashSet<ReservaContenedor>();
        }
    
        public int IdReserva { get; set; }
        public int ItinerarioReserva { get; set; }
        public int ClienteReserva { get; set; }
        public Nullable<System.DateTime> FechaReserva { get; set; }
        public int UsuarioReserva { get; set; }
        public string NroReserva { get; set; }
        public int PuertoDescargaReserva { get; set; }
        public string ObservacionesReserva { get; set; }
        public Nullable<bool> GeneradoEIRReserva { get; set; }
        public Nullable<int> PuertoEntregaReserva { get; set; }
        public Nullable<short> DiasLibresReserva { get; set; }
        public Nullable<short> CantidadEquiposReserva { get; set; }
        public Nullable<bool> SecundariaReserva { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Itinerario Itinerario { get; set; }
        public virtual Puerto Puerto { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservaContenedor> ReservaContenedor { get; set; }
    }
}
