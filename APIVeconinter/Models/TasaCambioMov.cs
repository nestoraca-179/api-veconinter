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
    
    public partial class TasaCambioMov
    {
        public int IdTasaCambioMov { get; set; }
        public int IdTasaCambio { get; set; }
        public System.DateTime FechaTasaCambioMov { get; set; }
        public double ValorTasaCambioMov { get; set; }
    
        public virtual TasaCambio TasaCambio { get; set; }
    }
}
