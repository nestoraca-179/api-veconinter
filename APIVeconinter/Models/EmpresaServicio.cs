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
    
    public partial class EmpresaServicio
    {
        public int IdEmpresaServicio { get; set; }
        public int IdEmpresa { get; set; }
        public int IdServicio { get; set; }
        public double CostoEmpresaServicio { get; set; }
        public bool ExentoIVAEmpresaServicio { get; set; }
    
        public virtual Empresa Empresa { get; set; }
        public virtual Servicio Servicio { get; set; }
    }
}