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
    
    public partial class PreliquidacionServicio
    {
        public int IdPreliquidacionServicio { get; set; }
        public int IdPreliquidacion { get; set; }
        public int IdServicio { get; set; }
        public double CantidadPrelServicio { get; set; }
        public double PrecioPrelServicioBS { get; set; }
        public double PrecioPreslServicioUSD { get; set; }
        public double TotalPrelServicioBS { get; set; }
        public double TotalPrelServicioUSD { get; set; }
    
        public virtual Preliquidacion Preliquidacion { get; set; }
        public virtual Servicio Servicio { get; set; }
    }
}
