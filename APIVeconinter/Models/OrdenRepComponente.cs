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
    
    public partial class OrdenRepComponente
    {
        public int IdOrdenComponente { get; set; }
        public int IdOrdenRep { get; set; }
        public int IdComponente { get; set; }
        public int IdLadoOrdComponente { get; set; }
        public Nullable<short> PosicionOrdComponente { get; set; }
        public string DimensionNroPiezaOrdComp { get; set; }
        public int MetodoRepOrdComp { get; set; }
        public int IdDañoOrdComp { get; set; }
    
        public virtual Componente Componente { get; set; }
        public virtual Daño Daño { get; set; }
        public virtual Lado Lado { get; set; }
        public virtual MetodoReparacion MetodoReparacion { get; set; }
        public virtual OrdenReparacion OrdenReparacion { get; set; }
    }
}
