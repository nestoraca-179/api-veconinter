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
    
    public partial class ItinerarioContenedor
    {
        public int IdItinerarioContenedor { get; set; }
        public int IdItinerario { get; set; }
        public int IdContenedor { get; set; }
        public string BLContenedor { get; set; }
        public string EmbarcadorContenedor { get; set; }
        public string ConsignatarioContenedor { get; set; }
        public string OrigenContenedor { get; set; }
        public string PolContenedor { get; set; }
        public string PodContenedor { get; set; }
        public string PrecintoContenedor { get; set; }
        public string MercanciaContenedor { get; set; }
        public string EmpaqueContenedor { get; set; }
        public Nullable<double> CantidadContenedor { get; set; }
        public Nullable<int> EstatusContenedor { get; set; }
        public string CondicionVentaContenedor { get; set; }
        public Nullable<double> PesoBrutoContenedor { get; set; }
        public Nullable<double> PesoNetoContenedor { get; set; }
        public Nullable<double> M3Contenedor { get; set; }
        public Nullable<double> TMinimoContenedor { get; set; }
        public Nullable<double> TMaximoContenedor { get; set; }
        public string HazContenedor { get; set; }
        public string ImoContenedor { get; set; }
        public string UnContenedor { get; set; }
        public string UsoSiduneaContenedor { get; set; }
    
        public virtual Contenedor Contenedor { get; set; }
        public virtual Itinerario Itinerario { get; set; }
    }
}