//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Savea.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Valor
    {
        public int Id { get; set; }
        public Nullable<int> RangoDesde { get; set; }
        public Nullable<int> RangoHasta { get; set; }
        public Nullable<int> Pregunta_id { get; set; }
    
        public virtual Pregunta Pregunta { get; set; }
    }
}
