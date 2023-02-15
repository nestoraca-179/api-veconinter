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
    
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            this.FacturaServicio = new HashSet<FacturaServicio>();
        }
    
        public int IdFactura { get; set; }
        public int NroFactura { get; set; }
        public string NroControlFactura { get; set; }
        public System.DateTime FechaFactura { get; set; }
        public int ClienteFactura { get; set; }
        public int EmpresaFactura { get; set; }
        public int TasaCambioFactura { get; set; }
        public double SubtotalFacturaBS { get; set; }
        public double IvaFacturaBS { get; set; }
        public double TotalFacturaBS { get; set; }
        public double SubTotalFacturaUSD { get; set; }
        public double IvaFacturaUSD { get; set; }
        public double TotalFacturaUSD { get; set; }
        public string ObservacionFactura { get; set; }
        public int UsuarioFactura { get; set; }
        public bool AnuladaFactura { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual TasaCambio TasaCambio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaServicio> FacturaServicio { get; set; }
    }
}